using System;

class Program
{
	static void Main(string[] args)
	{
		int[,] array = new int[5, 5];

		// Initialize the array
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				if (i == 2 && j == 2)
				{
					array[i, j] = 1;
				}
				else
				{
					array[i, j] = 0;
				}
			}
		}
		
		// Print the array
	        for (int i = 0; i < 5; i++)
	        {
			for (int j = 0; j < 5; j++)
		        {
				Console.Write(array[i, j]);
				if (j < 4)
			        {
					Console.Write(" ");
			        }
			}
			Console.WriteLine();
		}
	}
}
