using System;

/// <summary>
/// Represents a basic shape.
/// </summary>
public class Shape
{
	/// <summary>
	/// Calculates the area of the shape. To be implemented by derived classes.
	/// </summary>
	public virtual int Area()
	{
		throw new NotImplementedException("Area() is not implemented");
	}
}

/// <summary>
/// Represents a rectangle shape, inheriting from Shape.
/// </summary>
public class Rectangle : Shape
{
	private int width;
	private int height;

	/// <summary>
	/// Gets or sets the width of the rectangle.
	/// </summary>
	public int Width
	{
		get { return width; }
		set
		{
			if (value < 0)
				throw new ArgumentException("Width must be greater than or equal to 0");
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
				throw new ArgumentException("Height must be greater than or equal to 0");
			height = value;
		}
	}

	/// <summary>
	/// Calculates the area of the rectangle.
	/// </summary>
	/// <returns>The area of the rectangle.</returns>
	public override int Area()
	{
		return width * height;
	}

	/// <summary>
	/// Returns a string representation of the rectangle.
	/// </summary>
	/// <returns>A string in the format [Rectangle] 'width' / 'height'.</returns>
	public override string ToString()
	{
		return $"[Rectangle] {width} / {height}";
	}
}

/// <summary>
/// Represents a square shape, inheriting from Rectangle.
/// </summary>
public class Square : Rectangle
{
	private int size;

	/// <summary>
	/// Gets or sets the size of the square.
	/// </summary>
	public int Size
	{
		get { return size; }
		set
		{
			if (value < 0)
				throw new ArgumentException("Size must be greater than or equal to 0");
			size = value;
			Width = size;
			Height = size;
		}
	}

	/// <summary>
	/// Returns a string representation of the square.
	/// </summary>
	/// <returns>A string in the format [Square] 'size' / 'size'.</returns>
	public override string ToString()
	{
		return $"[Square] {size} / {size}";
	}
}
