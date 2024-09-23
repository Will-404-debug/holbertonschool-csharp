using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
	/// <summary>
	/// Tests for the Matrix class.
	/// </summary>
	public class MatrixTests
	{
		/// <summary>
		/// Tests the Divide method.
		/// </summary>
		[Test]
		public void TestDivide()
		{
			int[,] matrix = { { 10, 20 }, { 30, 40 } };
			int[,] result = Matrix.Divide(matrix, 10);
			Assert.AreEqual(1, result[0, 0]);
			Assert.AreEqual(2, result[0, 1]);
			Assert.AreEqual(3, result[1, 0]);
			Assert.AreEqual(4, result[1, 1]);
		}

		[Test]
		public void TestDivideByZero()
		{
			int[,] matrix = { { 10, 20 }, { 30, 40 } };
			var result = Matrix.Divide(matrix, 0);
			Assert.IsNull(result);
		}

		[Test]
		public void TestNullMatrix()
		{
			int[,] result = Matrix.Divide(null, 10);
			Assert.IsNull(result);
		}
	}
}
