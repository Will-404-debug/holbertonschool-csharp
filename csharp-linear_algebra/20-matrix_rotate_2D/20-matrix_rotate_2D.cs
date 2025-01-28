using System;

class MatrixMath
{
    /// <summary>
    /// Rotates a 2D square matrix by a given angle in radians.
    /// </summary>
    /// <param name="matrix">The 2D square matrix to rotate.</param>
    /// <param name="angle">The rotation angle in radians.</param>
    /// <returns>The rotated matrix, or a matrix containing -1 if the input is invalid.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Validate input: Check if the matrix is null or not square
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        // Rotation matrix components
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        // Create the rotation matrix
        double[,] rotationMatrix = new double[,]
        {
            { cosTheta, -sinTheta },
            { sinTheta, cosTheta }
        };

        // Initialize the result matrix
        double[,] rotatedMatrix = new double[2, 2];

        // Apply the rotation transformation
        for (int i = 0; i < 2; i++) // Iterate over rows
        {
            for (int j = 0; j < 2; j++) // Iterate over columns
            {
                rotatedMatrix[i, j] = Math.Round(
                    matrix[i, 0] * rotationMatrix[0, j] + matrix[i, 1] * rotationMatrix[1, j], 2
                );
            }
        }

        return rotatedMatrix;
    }
}
