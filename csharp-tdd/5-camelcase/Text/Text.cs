using System;

namespace Text
{
	/// <summary>
	/// Provides methods for string manipulation.
	/// </summary>
	public static class Str
	{
		/// <summary>
		/// Counts the number of words in a CamelCase formatted string.
		/// </summary>
		/// <param name="s">The input string.</param>
		/// <returns>The number of words in the string.</returns>
		public static int CamelCase(string s)
		{
			if (string.IsNullOrEmpty(s))
				return 0;

			int wordCount = 1; // Start with 1 to account for the first word
			bool allUppercase = true; // Flag to check if all characters are uppercase

			// Check if the string is entirely uppercase
			foreach (char c in s)
			{
				if (!char.IsUpper(c))
				{
					allUppercase = false;
					break;
				}

			}

			// If all characters are uppercase, return 1
			if (allUppercase)
				return 1;

			// Count the number of capital letters in the string
			for (int i = 1; i < s.Length; i++) // Start from index 1 to ignore the first character
			{
				if (char.IsUpper(s[i]))
				{
					wordCount++;
				}
			}

			return wordCount;
		}
	}
}
