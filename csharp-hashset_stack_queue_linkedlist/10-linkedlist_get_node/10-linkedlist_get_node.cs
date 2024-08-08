using System;
using System.Collections.Generic;

class LList
{
	public static int GetNode(LinkedList<int> myLList, int n)
	{
		int index = 0;

		// Iterate through the linked list
		foreach (int item in myLList)
		{
			if (index == n)
			{
				return item; // Return the value if the current index matches n
			}
			index++; // Increment index for each node
		}

		// If n is out of range, return 0
		return 0;
	}
}
