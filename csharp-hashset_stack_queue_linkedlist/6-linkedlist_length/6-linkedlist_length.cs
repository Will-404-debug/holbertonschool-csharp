using System;
using System.Collections.Generic;

class LList
{
	public static int Length(LinkedList<int> myLList)
	{
		int count = 0;

		// Iterate through the linked list
		foreach (int item in myLList)
		{
			count++; // Increment the count for each item
		}

		return count; // Return the total count
	}
}
