using System;
using System.Collections.Generic;

class List
{
	public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
	{
		List<int> result = new List<int>();

		// Check if either list is shorter than the listLength
		if (list1.Count < listLength || list2.Count < listLength)
		{
			Console.WriteLine("Out of range");
		}

		for (int i = 0; i < listLength; i++)
		{
			try
			{
				// Check if index is within the bounds of both lists
				if (i >= list1.Count || i >= list2.Count)
				{
					// If index is out of range for either list
					result.Add(0);
					continue;
				}

				// Perform division
				int divisionResult = list1[i] / list2[i];
				result.Add(divisionResult);
			}
			catch (DivideByZeroException)
			{
				// Handle division by zero
				Console.WriteLine("Cannot divide by zero");
				result.Add(0);
			}
			catch (Exception)
			{
				// Handle any unexpected exceptions
				Console.WriteLine("An unexpected error occurred.");
				result.Add(0);
			}
		}

		return result;
	}
}
