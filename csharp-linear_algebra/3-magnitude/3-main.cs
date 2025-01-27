using System;

class Program
{
    static void Main()
    {
        double[] vector2D = { 3, 9 };
        double[] vector3D = { 7, -3, -9 };
        double[] invalidVector = { 1, 2, 3, 4 };

        Console.WriteLine(VectorMath.Magnitude(vector2D)); // Output: 9.49
        Console.WriteLine(VectorMath.Magnitude(vector3D)); // Output: 11.79
        Console.WriteLine(VectorMath.Magnitude(invalidVector)); // Output: -1
    }
}
