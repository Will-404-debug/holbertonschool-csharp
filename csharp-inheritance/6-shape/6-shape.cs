using System;

// 5-shape.cs
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

/// <summary>
/// Represents a rectangle shape.
/// </summary>
public class Rectangle : Shape
{
	private int width;   // Private field for width
	private int height;  // Private field for height
	
	/// <summary>
	/// Gets or sets the width of the rectangle.
	/// </summary>
	public int Width
	{
		get { return width; }
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Width must be greater than or equal to 0.");
			}
			width = value;
		}
	}

	/// <summary>
	/// Gets or sets the height of the rectangle.
	/// </summary>
	public int Height
	{
		get { return height; }
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Height must be greater than or equal to 0.");
			}
			height = value;
		}
	}

	/// <summary>
	/// Calculates the area of the rectangle.
	/// </summary>
	/// <returns>The area of the rectangle.</returns>
	public override int Area()
	{
		return Width * Height; // Calculate area
	}
}
