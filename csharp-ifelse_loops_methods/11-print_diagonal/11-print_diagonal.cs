using System;

class Line
{
	public static void PrintDiagonal(int length)
	{
		if (length <= 0)
		{
			Console.WriteLine();
			return;
		}

		for (int i = 0; i < length; i++)
		{
			Console.Write(new string(' ', i)); // Print leading spaces
			Console.Write("\\"); // Print the diagonal line character
			Console.WriteLine(); // Move to the next line
		}
	}
}
