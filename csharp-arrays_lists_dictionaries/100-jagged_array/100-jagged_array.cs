using System;

class Program
{
	static void Main(string[] args)
	{
		// Create and initialize the jagged array
		int[][] jaggedArray = new int[3][];

		jaggedArray[0] = new int[] {0, 1, 2, 3};
		jaggedArray[1] = new int[] {0, 1, 2, 3, 4, 5, 6};
		jaggedArray[2] = new int[] {0, 1};

		// Print the jagged array
		foreach (int[] array in jaggedArray)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i]);
				if (i != array.Length - 1)
					Console.Write(" ");
			}
			Console.WriteLine();
		}
	}
}
