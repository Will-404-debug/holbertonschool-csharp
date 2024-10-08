// 2-subclass.cs
using System;

/// <summary>
/// This class provides methods for type checking.
/// </summary>
public class Obj
{
	/// <summary>
	/// Checks if a given type is a subclass of another specified type.
	/// </summary>
	/// <param name="derivedType">The type that is potentially derived.</param>
	/// <param name="baseType">The base type to check against.</param>
	/// <returns>
	/// True if the derivedType is a subclass of baseType and not the same as baseType; otherwise, False.
	/// </returns>
	public static bool IsOnlyASubclass(Type derivedType, Type baseType)
	{
		// Check if derivedType is a subclass of baseType, but not the same as baseType
		return derivedType.IsSubclassOf(baseType);
	}
}
