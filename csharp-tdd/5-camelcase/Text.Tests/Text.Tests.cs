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
		/// Test CamelCase with a standard CamelCase string.
		/// </summary>
		[Test]
		public void TestStandardCamelCase()
		{
			string input = "thisIsCamelCase";
			int result = Str.CamelCase(input);
			Assert.AreEqual(4, result);  // Should return 4 words
		}

		/// <summary>
		/// Test CamelCase with an empty string.
		/// </summary>
		[Test]
		public void TestEmptyString()
		{
			string input = "";
			int result = Str.CamelCase(input);
			Assert.AreEqual(0, result);  // Should return 0 words
		}

		/// <summary>
		/// Test CamelCase with a single word.
		/// </summary>
		[Test]
		public void TestSingleWord()
		{
			string input = "Hello";
			int result = Str.CamelCase(input);
			Assert.AreEqual(1, result);  // Should return 1 word
		}

		/// <summary>
		/// Test CamelCase with multiple words.
		/// </summary>
		[Test]
		public void TestMultipleWords()
		{
			string input = "OneTwoThree";
			int result = Str.CamelCase(input);
			Assert.AreEqual(3, result);  // Should return 3 words
		}

		/// <summary>
		/// Test CamelCase with all capital letters.
		/// </summary>
		[Test]
		public void TestAllCapitalLetters()
		{
			string input = "ALLCAPS";
			int result = Str.CamelCase(input);
			Assert.AreEqual(1, result);  // Should return 1 word
		}
	}
}
