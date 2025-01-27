using System;

namespace VectorMath
{
    /// <summary>
    /// Provides methods for vector calculations.
    /// </summary>
    public static class VectorMath
    {
        /// <summary>
        /// Calculates and returns the magnitude (length) of a 2D or 3D vector.
        /// </summary>
        /// <param name="vector">The input vector as an array of doubles.</param>
        /// <returns>The magnitude of the vector, rounded to the nearest hundredth. Returns -1 if the vector is not 2D or 3D.</returns>
        public static double Magnitude(double[] vector)
        {
            if (vector.Length == 2)
            {
                return Math.Round(Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1]), 2);
            }
            else if (vector.Length == 3)
            {
                return Math.Round(Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1] + vector[2] * vector[2]), 2);
            }
            return -1; // Return -1 if the vector is not 2D or 3D
        }
    }
}
