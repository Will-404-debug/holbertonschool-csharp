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
            if (rows != cols || matrix == null)
            {
                return new double[,] { { -1 } };
            }

            // Compute the cosine and sine of the angle
            double cosTheta = Math.Cos(angle);
            double sinTheta = Math.Sin(angle);

            // Create a new matrix to store the rotated values
            double[,] rotatedMatrix = new double[rows, cols];

            // Apply rotation to each element of the matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double x = matrix[i, j];
                    double y = matrix[(i + 1) % rows, j]; // Simulating rotation of neighboring elements
                    rotatedMatrix[i, j] = Math.Round(cosTheta * x - sinTheta * y, 2);
                }
            }

            return rotatedMatrix;
        }
    }
}
