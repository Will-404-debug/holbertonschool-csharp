using System;
using System.Text.RegularExpressions;

namespace Text
{
	/// <summary>
	/// Provides methods for working with strings.
	/// </summary>
	public static class Str
	{
		/// <summary>
		/// Determines if a string is a palindrome, ignoring case, spaces, and punctuation.
		/// </summary>
		/// <param name="s">The string to check.</param>
		/// <returns>True if the string is a palindrome; otherwise, False.</returns>
		public static bool IsPalindrome(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return true;
			}

			// Remove all non-alphanumeric characters and convert to lowercase
			string cleaned = Regex.Replace(s.ToLower(), @"[^a-z0-9]", "");

			// Check if the cleaned string is the same forwards and backwards
			int len = cleaned.Length;
			for (int i = 0; i < len / 2; i++)
			{
				if (cleaned[i] != cleaned[len - 1 - i])
				{
					return false;
				}

			}

			return true;
		}
	}
}
