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
				// Check if the index is within the bounds of both lists
				if (i >= list1.Count || i >= list2.Count)
				{
					Console.WriteLine("Out of range");
					result.Add(0);
				}
				else
				{
					try
					{
						int divisionResult = list1[i] / list2[i];
						result.Add(divisionResult);
					}
					catch (DivideByZeroException)
					{
						Console.WriteLine("Cannot divide by zero");
						result.Add(0);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Unexpected error: " + ex.Message);
				result.Add(0);
			}
		}

		return result;
	}
}
