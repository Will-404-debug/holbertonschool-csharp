//0-is.cs
/// <summary>
/// This class provides methods for type checking.
/// </summary>
public class Obj
{
	/// <summary>
	/// Checks if the given object is of type int.
	/// </summary>
	/// <param name="obj">The object to check.</param>
	/// <returns> True if the object is an int, otherwise False.</returns>
	public static bool IsOfTypeInt(object obj)
	{
		// Return true if obj is of type int, false otherwise
		return obj is int;
	}
}
