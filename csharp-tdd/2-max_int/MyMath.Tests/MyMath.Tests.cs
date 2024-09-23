using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
	/// <summary>*
	/// Tests for the Operations class.
	/// </summary>
	public class OperationsTests
	{
		/// <summary>
		/// Tests finding the max value in a list.
		/// </summary>
		[Test]
		public void TestMaxNormal()
		{
			List<int> numbers = new List<int> { 1, 3, 5, 7, 9 };
			int result = Operations.Max(numbers);
			Assert.AreEqual(9, result);
		}

		/// <summary>
		/// Tests finding the max value when the list is empty.
		/// </summary>
		[Test]
		public void TestMaxEmpty()
		{
			List<int> numbers = new List<int>();
			int result = Operations.Max(numbers);
			Assert.AreEqual(0, result);
		}

		/// <summary>
		/// Tests finding the max value in a list with negative numbers.
		/// </summary>
		[Test]
		public void TestMaxWithNegativeNumbers()
		{
			List<int> numbers = new List<int> { -10, -20, -5, -30 };
			int result = Operations.Max(numbers);
			Assert.AreEqual(-5, result);
		}

		/// <summary>
		/// Tests finding the max value in a null list.
		/// </summary>
		[Test]
		public void TestMaxNull()
		{
			List<int> numbers = null;
			int result = Operations.Max(numbers);
			Assert.AreEqual(0, result);
		}
	}
}
