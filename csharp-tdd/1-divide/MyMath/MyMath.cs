using System;

namespace MyMath
{
	/// <summary>
	/// Contains matrix operations.
	/// </summary>
	public static class Matrix
	{
		/// <summary>
		/// Divides all elements of a matrix by a specified number.
		/// </summary>
		/// <param name="matrix">The matrix to divide.</param>
		/// <param name="num">The divisor.</param>
		/// <returns>A new matrix containing divided elements, or null if an error occurs.</returns>
		public static int[,] Divide(int[,] matrix, int num)
		{
			if (matrix == null)
			{
				return null;
			}

			if (num == 0)
			{
				Console.WriteLine("Num cannot be 0");
				return null;
			}

			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);
			int[,] result = new int[rows, cols];
			
			try
			{
				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < cols; j++)
					{
						result[i, j] = matrix[i, j] / num;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return result;
		}
	}
}
