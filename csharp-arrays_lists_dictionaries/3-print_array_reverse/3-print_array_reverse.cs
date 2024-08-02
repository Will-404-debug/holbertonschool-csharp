using System;

class Array
{
	public static void Reverse(int[] array)
	{
		if (array == null || array.Length == 0)
		{
			//Print a blank line if the array is null or empty
			Console.WriteLine();
			return;
		}

		for (int i = array.Length - 1; i >= 0; i--)
		{
			Console.Write(array[i]);
			if (i > 0)
			{
				Console.Write(" ");
			}
		}

		Console.WriteLine();
       	}
}
