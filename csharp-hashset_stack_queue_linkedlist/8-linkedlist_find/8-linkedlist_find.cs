using System;
using System.Collections.Generic;

class LList
{
	public static int FindNode(LinkedList<int> myLList, int value)
	{
		int index = 0;

		// Iterate through the linked list
		foreach (int item in myLList)
		{
			if (item == value)
			{
				return index; // Return the index if value is found
			}
			index++; // Increment the index for each element
		}

		// If value is not found, return -1
		return -1;
	}
}
