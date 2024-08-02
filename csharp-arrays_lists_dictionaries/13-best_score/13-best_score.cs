using System;
using System.Collections.Generic;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		if (myList.Count == 0)
		{
			return "None";
		}

		string bestKey = null;
		int bestValue = int.MinValue;

		foreach (KeyValuePair<string, int> entry in myList)
		{
			if (entry.Value > bestValue)
			{
				bestValue = entry.Value;
				bestKey = entry.Key;
			}
		}

		return bestKey;
	}
}
