using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
	/// <summary>
	/// Tests for the Operations class.
	/// </summary>
	public class OperationsTests
	{
		/// <summary>
		/// Tests the Add method.
		/// </summary>
		[Test]
		public void TestAdd()
		{
			Assert.AreEqual(5, Operations.Add(2, 3));
			Assert.AreEqual(-1, Operations.Add(2, -3));
			Assert.AreEqual(0, Operations.Add(0, 0));
			Assert.AreEqual(7, Operations.Add(7, 0));
		}
	}
}
