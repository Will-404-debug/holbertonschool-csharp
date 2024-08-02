using System;
using System.Collections.Generic;

class Dictionary
{
	public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
	{
		// Create a new dictionary to store the multiplied values
		Dictionary<string, int> newDict = new Dictionary<string, int>();

		// Iterate over each key-value pair in the original dictionary
		foreach (KeyValuePair<string, int> entry in myDict)
		{
			// Multiply the value by 2 and add it to the new dictionary
			newDict[entry.Key] = entry.Value * 2;
		}

		// Return the new dictionary with multiplied values
		return newDict;
	}
}
