﻿using System;

// 5-shape.cs
/// <summary>
/// Represents a generic geometric shape.
/// </summary>
public class Shape
{
	/// <summary>
	/// Calculates the area of the shape.
	/// </summary>
	/// <returns>The area of the shape.</returns>
	/// <exception cref="NotImplementedException">Thrown when the method is not implemented.</exception>
	public virtual int Area()
	{
		throw new NotImplementedException("Area() is not implemented");
	}
}

// 6-shape.cs
/// <summary>
/// Represents a rectangle shape, inheriting from Shape.
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
				Console.WriteLine("Height must be greater than or equal to 0.");
			}
			else
			{
				height = value;
			}
		}
	}
}
