using System;
using System.Collections.Generic;

class LList
{
	public static LinkedList<int> CreatePrint(int size)
	{
		// Create a new LinkedList of integers
		LinkedList<int> linkedList = new LinkedList<int>();

		// Check if the size is non-negative
		if (size < 0)
		{
			return linkedList; // Return an empty list if size is negative
		}

		// Populate the LinkedList with integers from 0 to size-1
		for (int i = 0; i < size; i++)
		{
			linkedList.AddLast(i);
			Console.WriteLine(i); // Print the current integer
		}

		// Return the created LinkedList
		return linkedList;
	}
}
