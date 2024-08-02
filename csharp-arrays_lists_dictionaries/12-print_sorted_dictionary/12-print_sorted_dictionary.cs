using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
	public static void PrintSorted(Dictionary<string, string> myDict)
	{
		// Get the list of keys and sort them
		List<string> keys = myDict.Keys.ToList();
		keys.Sort();

		// Iterate over each sorted key and print the key-value pair
		foreach (string key in keys)
		{
			Console.WriteLine("{0}: {1}", key, myDict[key]);
		}
	}
}
