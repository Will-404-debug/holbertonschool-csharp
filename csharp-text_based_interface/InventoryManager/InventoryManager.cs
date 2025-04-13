using System;
using InventoryLibrary;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManager
{
    class Program
    {
        static JSONStorage storage = new JSONStorage();

        static void Main(string[] args)
        {
            storage.Load();
            PrintMenu();

            while (true)
            {
                Console.Write("\nEnter Command: ");
                string? input = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(input)) continue;

                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0].ToLower();

                switch (command)
                {
                    case "classnames":
                        PrintClassNames();
                        break;
                    case "all":
                        if (parts.Length == 1) PrintAllObjects();
                        else PrintAllOfClass(parts[1]);
                        break;
                    case "create":
                        if (parts.Length < 2) Console.WriteLine("Please provide a class name.");
                        else CreateObject(parts[1]);
                        break;
                    case "show":
                        if (parts.Length < 3) Console.WriteLine("Usage: Show <ClassName> <id>");
                        else ShowObject(parts[1], parts[2]);
                        break;
                    case "update":
                        if (parts.Length < 3) Console.WriteLine("Usage: Update <ClassName> <id>");
                        else UpdateObject(parts[1], parts[2]);
                        break;
                    case "delete":
                        if (parts.Length < 3) Console.WriteLine("Usage: Delete <ClassName> <id>");
                        else DeleteObject(parts[1], parts[2]);
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }

                Console.WriteLine();
                PrintMenu();
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine(@"
Inventory Manager
-------------------------
<ClassNames>             show all ClassNames of objects
<All>                    show all objects
<All [ClassName]>        show all objects of a ClassName
<Create [ClassName]>     a new object
<Show [ClassName id]>    an object
<Update [ClassName id]>  an object
<Delete [ClassName id]>  an object
<Exit>");
        }

        static void PrintClassNames()
        {
            var classNames = storage.All()
                                    .Keys
                                    .Select(k => k.Split('.')[0])
                                    .Distinct();

            foreach (var className in classNames)
                Console.WriteLine(className);
        }

        static void PrintAllObjects()
        {
            foreach (var obj in storage.All())
                Console.WriteLine($"{obj.Key}: {System.Text.Json.JsonSerializer.Serialize(obj.Value)}");
        }

        static void PrintAllOfClass(string className)
        {
            var found = false;
            foreach (var obj in storage.All())
            {
                if (obj.Key.StartsWith(className + ".", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{obj.Key}: {System.Text.Json.JsonSerializer.Serialize(obj.Value)}");
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine($"{className} is not a valid object type");
        }

        static void CreateObject(string className)
        {
            BaseClass? obj = null;

            try
            {
                if (className.Equals("item", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter Item Name: ");
                    string? name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name)) { Console.WriteLine("Name is required."); return; }
                    obj = new Item(name);
                }
                else if (className.Equals("user", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter User Name: ");
                    string? name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name)) { Console.WriteLine("Name is required."); return; }
                    obj = new User(name);
                }
                else if (className.Equals("inventory", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter User ID: ");
                    string? userId = Console.ReadLine();
                    Console.Write("Enter Item ID: ");
                    string? itemId = Console.ReadLine();
                    Console.Write("Enter Quantity: ");
                    string? qtyInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(itemId) || string.IsNullOrWhiteSpace(qtyInput))
                    {
                        Console.WriteLine("All fields are required.");
                        return;
                    }

                    if (!int.TryParse(qtyInput, out int quantity))
                    {
                        Console.WriteLine("Invalid quantity.");
                        return;
                    }

                    obj = new Inventory(userId, itemId, quantity);
                }
                else
                {
                    Console.WriteLine($"{className} is not a valid object type");
                    return;
                }

                storage.New(obj);
                storage.Save();
                Console.WriteLine("Object created.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void ShowObject(string className, string id)
        {
            string key = $"{className}.{id}";
            if (storage.All().TryGetValue(key, out BaseClass? obj))
            {
                Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(obj, new System.Text.Json.JsonSerializerOptions { WriteIndented = true }));
            }
            else
            {
                Console.WriteLine($"Object {id} could not be found");
            }
        }

        static void UpdateObject(string className, string id)
        {
            string key = $"{className}.{id}";
            if (!storage.All().ContainsKey(key))
            {
                Console.WriteLine($"Object {id} could not be found");
                return;
            }

            var obj = storage.All()[key];

            Console.WriteLine("Enter new values (leave blank to skip):");

            foreach (var prop in obj.GetType().GetProperties())
            {
                if (prop.Name == "id" || prop.Name.StartsWith("date")) continue;

                Console.Write($"{prop.Name} ({prop.PropertyType.Name}): ");
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    try
                    {
                        object? value = Convert.ChangeType(input, prop.PropertyType);
                        prop.SetValue(obj, value);
                    }
                    catch
                    {
                        Console.WriteLine($"Invalid input for {prop.Name}, skipping...");
                    }
                }
            }

            obj.date_updated = DateTime.Now;
            storage.Save();
            Console.WriteLine("Object updated.");
        }

        static void DeleteObject(string className, string id)
        {
            string key = $"{className}.{id}";
            if (storage.All().Remove(key))
            {
                storage.Save();
                Console.WriteLine("Object deleted.");
            }
            else
            {
                Console.WriteLine($"Object {id} could not be found");
            }
        }
    }
}
