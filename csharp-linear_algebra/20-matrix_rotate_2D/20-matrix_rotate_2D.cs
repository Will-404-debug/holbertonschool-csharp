using System;

namespace MatrixMath
{
    public class MatrixMath
    {
        /// <summary>
        /// Rotates a square 2D matrix by a given angle in radians.
        /// </summary>
        /// <param name="matrix">The 2D matrix to be rotated.</param>
        /// <param name="angle">The angle of rotation in radians.</param>
        /// <returns>The rotated matrix, or a matrix containing -1 if invalid.</returns>
        public static double[,] Rotate2D(double[,] matrix, double angle)
        {
            // Validate that the matrix is a 2x2 matrix
            if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            {
                return new double[,] { { -1 } };
            }

            // Define the rotation matrix
            double cosTheta = Math.Round(Math.Cos(angle), 2);
            double sinTheta = Math.Round(Math.Sin(angle), 2);

            double[,] rotationMatrix = new double[,]
            {
                { cosTheta, -sinTheta },
                { sinTheta, cosTheta }
            };

            // Perform matrix multiplication (R * M)
            double[,] result = new double[2, 2];
            for (int i = 0; i < 2; i++) // Rows of the result matrix
            {
                for (int j = 0; j < 2; j++) // Columns of the result matrix
                {
                    result[i, j] = 0;
                    for (int k = 0; k < 2; k++) // Dot product calculation
                    {
                        result[i, j] += rotationMatrix[i, k] * matrix[k, j];
                    }
                    // Round the result to two decimal places
                    result[i, j] = Math.Round(result[i, j], 2);
                }
            }

            return result;
        }
    }
}
