using System;

namespace VectorMath
{
    public class VectorMath
    {
        /// <summary>
        /// Calculates and returns the magnitude (length) of a vector.
        /// </summary>
        /// <param name="vector">A double array representing the vector (2D or 3D).</param>
        /// <returns>The magnitude of the vector rounded to the nearest hundredth, or -1 if invalid.</returns>
        public static double Magnitude(double[] vector)
        {
            // Validate input (vector must be 2D or 3D and not null)
            if (vector == null || (vector.Length != 2 && vector.Length != 3))
                return -1;

            // Calculate the sum of the squares
            double sumOfSquares = 0;
            foreach (double component in vector)
            {
                sumOfSquares += component * component;
            }

            // Calculate magnitude and round to the nearest hundredth
            double magnitude = Math.Sqrt(sumOfSquares);
            return Math.Round(magnitude, 2);
        }
    }
}
