using System;
using System.Collections.Generic;

class List
{
	public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
	{
		List<int> result = new List<int>();

		try
		{
			// Check if either list is too short
			if (list1.Count < listLength || list2.Count < listLength)
			{
				Console.WriteLine("Out of range");
				return result;
			}

			for (int i = 0; i < listLength; i++)
			{
				try
				{
					// Perform division and handle division by zero
					int divisionResult = list1[i] / list2[i];
					result.Add(divisionResult);
				}
				catch (DivideByZeroException)
				{
					Console.WriteLine("Cannot divide by zero");
					result.Add(0);
				}
				catch (Exception)
				{
					// Handle any unexpected exceptions
					result.Add(0);
				}

			}
		}
		catch (Exception)
		{
			// Catch any other unexpected exceptions
			Console.WriteLine("An unexpected error occurred.");
		}

		return result;
	}
}
