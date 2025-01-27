using System;

namespace MatrixMath
{
    public class MatrixMath
    {
        /// <summary>
        /// Rotates a square 2D matrix by a given angle in radians.
        /// </summary>
        /// <param name="matrix">The square 2D matrix to rotate.</param>
        /// <param name="angle">The rotation angle in radians.</param>
        /// <returns>The rotated matrix, or a matrix containing -1 if the input is invalid.</returns>
        public static double[,] Rotate2D(double[,] matrix, double angle)
        {
            // Validate input: Check if the matrix is square
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if (rows != cols)
            {
                return new double[,] { { -1 } };
            }

            // Precompute cosine and sine of the angle
            double cosTheta = Math.Cos(angle);
            double sinTheta = Math.Sin(angle);

            // Initialize the resulting matrix
            double[,] result = new double[rows, cols];

            // Perform rotation using matrix multiplication (R * M)
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = Math.Round(
                        cosTheta * matrix[i, j] - sinTheta * matrix[(j + rows - 1) % rows, i],
                        2
                    );
                }
            }

            return result;
        }
    }
}
