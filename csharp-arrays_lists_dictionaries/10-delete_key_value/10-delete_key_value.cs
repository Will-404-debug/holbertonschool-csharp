using System;
using System.Collections.Generic;

class Dictionary
{
	public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
	{
		// Check if the key exists in the dictionary and remove it if it does
		if (myDict.ContainsKey(key))
		{
			myDict.Remove(key);
		}

		// Return the updated dictionary
		return myDict;
	}
}
