using System;
using System.Collections.Generic;

namespace Text
{
	/// <summary>
	/// Provides methods for string manipulation.
	/// </summary>
	public static class Str
	{
		/// <summary>
		/// Finds the index of the first non-repeating character in a string.
		/// </summary>
		/// <param name="s">The string to check.</param>
		/// <returns>The index of the first non-repeating character, or -1 if none exists.</returns>
		public static int UniqueChar(string s)
		{
			if (string.IsNullOrEmpty(s))
				return -1;

			Dictionary<char, int> charCount = new Dictionary<char, int>();

			// Count occurrences of each character
			foreach (char c in s)
			{
				if (charCount.ContainsKey(c))
					charCount[c]++;
				else
					charCount[c] = 1;
			}

			// Find the first character with a count of 1
			for (int i = 0; i < s.Length; i++)
			{
				if (charCount[s[i]] == 1)
					return i;
			}

			return -1;  // No unique character found
		}
	}
}
