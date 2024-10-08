// 1-instance.cs
using System;  // Add this to use Array class

/// <summary>
/// This class provides methods for type checking.
/// </summary>
public class Obj
{
	/// <summary>
	/// Checks if the given object is an instance of an array or a class that inherits from Array.
	/// </summary>
	/// <param name="obj">The object to check.</param>
	/// <returns>True if the object is an instance of Array or inherits from Array, otherwise False.</returns>
	public static bool IsInstanceOfArray(object obj)
	{
		// Return true if obj is an array or inherits from Array
		return obj is Array;
	}
}
