using System;
using System.Collections.Generic;

class Dictionary
{
	public static int NumberOfKeys(Dictionary<string, string> myDict)
	{
		int keyCount = 0;

		// Iterate through the dictionary keys
		foreach (var key in myDict.Keys)
		{
			keyCount++;
		}

		return keyCount;
	}
}
