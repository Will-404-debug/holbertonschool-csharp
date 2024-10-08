// 3-type_get.cs
using System;
using System.Reflection;

/// <summary>
/// This class provides methods for inspecting the properties and methods of an object.
/// </summary>
public class Obj
{
	/// <summary>
	/// Prints the names of the available properties and methods of an object.
	/// </summary>
	/// <param name="myObj">The object to inspect.</param>
	public static void Print(object myObj)
	{
		// Get the Type of the object
		Type objType = myObj.GetType();

		// Print the name of the class and its properties
		Console.WriteLine($"{objType.Name} Properties:");

		// Get and print all properties
		PropertyInfo[] properties = objType.GetProperties();
		foreach (var prop in properties)
		{
			Console.WriteLine(prop.Name);
		}

		// Print the name of the class and its methods
		Console.WriteLine($"{objType.Name} Methods:");

		// Get and print all methods
		MethodInfo[] methods = objType.GetMethods();
		foreach (var method in methods)
		{
			Console.WriteLine(method.Name);
		}
	}
}
