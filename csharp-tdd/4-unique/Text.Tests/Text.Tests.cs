using NUnit.Framework;
using Text;

namespace Text.Tests
{
	/// <summary>
	/// Tests for the Str class.
	/// </summary>
	public class StrTests
	{
		/// <summary>
		/// Test UniqueChar with a simple case where the first unique character is in the middle.
		/// </summary>
		[Test]
		public void TestMiddleUniqueChar()
		{
			string input = "alphabet";
			int result = Str.UniqueChar(input);
			Assert.AreEqual(1, result);  // 'l' is the first non-repeating character
		}

		/// <summary>
		/// Test UniqueChar with a string with no unique characters.
		/// </summary>
		[Test]
		public void TestNoUniqueChar()
		{
			string input = "aabbcc";
			int result = Str.UniqueChar(input);
			Assert.AreEqual(-1, result);  // No unique characters
		}

		/// <summary>
		/// Test UniqueChar with an empty string.
		/// </summary>
		[Test]
		public void TestEmptyString()
		{
			string input = "";
			int result = Str.UniqueChar(input);
			Assert.AreEqual(-1, result);  // Empty string should return -1
		}

		/// <summary>
		/// Test UniqueChar with a string where the first character is unique.
		/// </summary>
		[Test]
		public void TestFirstCharUnique()
		{
			string input = "abcde";
			int result = Str.UniqueChar(input);
			Assert.AreEqual(0, result);  // 'a' is the first non-repeating character
		}

		/// <summary>
		/// Test UniqueChar with a string where the last character is unique.
		/// </summary>
		[Test]
		public void TestLastCharUnique()
		{
			string input = "aabbccdef";
			int result = Str.UniqueChar(input);
			Assert.AreEqual(6, result);  // 'f' is the first non-repeating character
		}
	}
}
