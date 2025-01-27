using System;

namespace MatrixMath
{
    public class MatrixMath
    {
        /// <summary>
        /// Rotates a 2x2 2D matrix by a given angle in radians.
        /// </summary>
        /// <param name="matrix">The 2x2 matrix to rotate.</param>
        /// <param name="angle">The rotation angle in radians.</param>
        /// <returns>The rotated matrix, or a matrix containing -1 if the input is invalid.</returns>
        public static double[,] Rotate2D(double[,] matrix, double angle)
        {
            // Validate input: the matrix must be 2x2
            if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            {
                return new double[,] { { -1 } };
            }

            // Create the rotation matrix
            double cosTheta = Math.Cos(angle);
            double sinTheta = Math.Sin(angle);

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
                    // Calculate the dot product
                    result[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        result[i, j] += rotationMatrix[i, k] * matrix[k, j];
                    }
                    // Round to two decimal places
                    result[i, j] = Math.Round(result[i, j], 2);
                }
            }

            return result;
        }
    }
}
