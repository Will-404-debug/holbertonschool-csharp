using System;

// 5-shape.cs
/// <summary>
/// Represents a generic geometric shape.
/// </summary>
class Shape
{
	/// <summary>
	/// Virtual method Area which throws a NotImplementedException.
	/// </summary>
	/// <returns>Throws NotImplementedException</returns>
	public virtual int Area()
	{
		throw new NotImplementedException("Area() is not implemented");
	}
}

// 6-shape.cs
/// <summary>
/// Represents a rectangle shape, inheriting from Shape.
/// </summary>
class Rectangle : Shape
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
				// Output error message for negative width
				Console.WriteLine("Width must be greater than or equal to 0.");
			}
			else
			{
				width = value;
			}
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
				// Output error message for negative height
				Console.WriteLine("Height must be greater than or equal to 0.");
			}
			else
			{
				height = value;
			}
		}
	}
}
