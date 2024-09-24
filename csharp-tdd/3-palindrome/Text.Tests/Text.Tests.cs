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
		/// Tests the IsPalindrome method with a simple palindrome.
		/// </summary>
		[Test]
		public void TestSimplePalindrome()
		{
			string input = "level";
			bool result = Str.IsPalindrome(input);
			Assert.IsTrue(result);
		}

		/// <summary>
		/// Tests the IsPalindrome method with mixed case letters.
		/// </summary>
		[Test]
		public void TestPalindromeCaseInsensitive()
		{
			string input = "Racecar";
			bool result = Str.IsPalindrome(input);
			Assert.IsTrue(result);
		}

		/// <summary>
		/// Tests the IsPalindrome method with spaces and punctuation.
		/// </summary>
		[Test]
		public void TestPalindromeWithSpacesAndPunctuation()
		{
			string input = "A man, a plan, a canal: Panama.";
			bool result = Str.IsPalindrome(input);
			Assert.IsTrue(result);
		}

		/// <summary>
		/// Tests the IsPalindrome method with a non-palindrome string.
		/// </summary>
		[Test]
		public void TestNotAPalindrome()
		{
			string input = "hello";
			bool result = Str.IsPalindrome(input);
			Assert.IsFalse(result);
		}

		/// <summary>
		/// Tests the IsPalindrome method with an empty string.
		/// </summary>
		[Test]
		public void TestEmptyString()
		{
			string input = "";
			bool result = Str.IsPalindrome(input);
			Assert.IsTrue(result);
		}

		/// <summary>
		/// Tests the IsPalindrome method with a string that contains only punctuation.
		/// </summary>
		[Test]
		public void TestPunctuationOnly()
		{
			string input = ".,!?";
			bool result = Str.IsPalindrome(input);
			Assert.IsTrue(result);
		}
	}
}
