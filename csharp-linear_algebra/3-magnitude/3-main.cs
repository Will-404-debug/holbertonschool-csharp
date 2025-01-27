using System;
using LinearAlgebra;


class Program
{
    static void Main(string[] args)
    {
        double[] vector2D = { 3, 4 };
        double[] vector3D = { 1, 2, 2 };
        double[] invalidVector = { 1 };

        Console.WriteLine(VectorMath.Magnitude(vector2D)); // Output: 5
        Console.WriteLine(VectorMath.Magnitude(vector3D)); // Output: 3
        Console.WriteLine(VectorMath.Magnitude(invalidVector)); // Output: -1
    }
}
