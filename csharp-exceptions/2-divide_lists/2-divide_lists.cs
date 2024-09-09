using System;
using System.Collections.Generic;

class List
{
	public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
	{
		List<int> result = new List<int>();

		for (int i = 0; i < listLength; i++)
		{
			try
			{
				// Check if the index is out of range for either list
				if (i >= list1.Count || i >= list2.Count)
				{
					Console.WriteLine("Out of range");
					break; // Stop the loop if one of the lists is too short
				}

				// Check if the element in the second list is zero (division by zero)
				if (list2[i] == 0)
				{
					Console.WriteLine("Cannot divide by zero");
					result.Add(0);
				}
				else
				{
					// Perform division and add the result
					result.Add(list1[i] / list2[i]);
				}
			}
			catch (Exception)
			{
				result.Add(0);
			}
		}

		return result;
	}
}
