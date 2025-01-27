using System;

namespace LinearAlgebra
{
    /// <summary>
    /// A class containing various vector math operations.
    /// </summary>
    public class VectorMath
    {
        /// <summary>
        /// Calculates and returns the magnitude (length) of a given vector.
        /// </summary>
        /// <param name="vector">An array representing a 2D or 3D vector.</param>
        /// <returns>The magnitude of the vector rounded to the nearest hundredth, or -1 if invalid.</returns>
        public static double Magnitude(double[] vector)
        {
            if (vector.Length == 2)
            {
                // 2D vector magnitude: sqrt(x^2 + y^2)
                return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)), 2);
            }
            else if (vector.Length == 3)
            {
                // 3D vector magnitude: sqrt(x^2 + y^2 + z^2)
                return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)), 2);
            }
            else
            {
                // Invalid vector
                return -1;
            }
        }
    }
}
