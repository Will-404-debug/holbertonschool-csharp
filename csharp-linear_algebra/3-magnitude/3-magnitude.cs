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
            // Check if the vector is 2D or 3D
            if (vector.Length != 2 && vector.Length != 3)
                return -1;

            // Calculate the sum of squares
            double sumOfSquares = 0;
            foreach (double component in vector)
            {
                sumOfSquares += Math.Pow(component, 2);
            }

            // Calculate the magnitude and round to the nearest hundredth
            double magnitude = Math.Sqrt(sumOfSquares);
            return Math.Round(magnitude, 2);
        }
    }
}
