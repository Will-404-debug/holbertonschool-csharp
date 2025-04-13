using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        private string filePath = "storage/inventory_manager.json";

        public Dictionary<string, BaseClass> objects { get; private set; } = new Dictionary<string, BaseClass>();

        public Dictionary<string, BaseClass> All()
        {
            return objects;
        }

        public void New(BaseClass obj)
        {
            string key = obj.GetType().Name + "." + obj.id;
            objects[key] = obj;
        }

        public void Save()
        {
            Directory.CreateDirectory("storage");
            string json = JsonConvert.SerializeObject(objects, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void Load()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No storage file found, starting with an empty dictionary.");
                objects = new Dictionary<string, BaseClass>();
                return;
            }

            string json = File.ReadAllText(filePath);
            if (string.IsNullOrWhiteSpace(json))
            {
                Console.WriteLine("Storage file is empty, starting with an empty dictionary.");
                objects = new Dictionary<string, BaseClass>();
                return;
            }

            try
            {
                objects = JsonConvert.DeserializeObject<Dictionary<string, BaseClass>>(json)
                          ?? new Dictionary<string, BaseClass>();
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error reading storage file. The file may be corrupted.");
                Console.WriteLine("Exception message: " + ex.Message);
                objects = new Dictionary<string, BaseClass>();
            }
        }
    }
}
