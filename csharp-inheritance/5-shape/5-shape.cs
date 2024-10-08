using System;

/// <summary>
/// Represents a generic shape.
/// </summary>
public class Shape
{
	/// <summary>
	/// Calculates the area of the shape.
	/// </summary>
	/// <returns>Throws NotImplementedException.</returns>
	public virtual int Area()
	{
		throw new NotImplementedException("Area() is not implemented");
	}
}
