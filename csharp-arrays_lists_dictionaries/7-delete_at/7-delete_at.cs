using System;
using System.Collections.Generic;

class List
{
	public static List<int> DeleteAt(List<int> myList, int index)
	{
		// Check if the index is out of range
		if (index < 0 || index >= myList.Count)
		{
			Console.WriteLine("Index is out of range");
			return myList;
		}

		// Create a new list excluding the element at the given index
		List<int> newList = new List<int>();

		for (int i = 0; i < myList.Count; i++)
		{
			if (i != index)
			{
				newList.Add(myList[i]);
			}
		}

		// Replace the contents of myList with the new list
		myList.Clear();
		myList.AddRange(newList);
		
		return newList;
	}
}
