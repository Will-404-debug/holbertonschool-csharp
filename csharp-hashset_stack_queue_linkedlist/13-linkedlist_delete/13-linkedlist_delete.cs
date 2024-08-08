using System;
using System.Collections.Generic;

class LList
{
	public static void Delete(LinkedList<int> myLList, int index)
	{
		// If the list is empty, return
		if (myLList.First == null)
			return;

		// If the index is negative, return
		if (index < 0)
			return;

		// Traverse the list to find the node at the specified index
		LinkedListNode<int> current = myLList.First;
		int currentIndex = 0;

		// Special case for deleting the first node
		if (index == 0)
		{
			myLList.RemoveFirst();
			return;
		}

		// Traverse the list to find the node at the specified index
		while (current != null && currentIndex < index)
		{
			current = current.Next;
			currentIndex++;
		}

		// If the node at the specified index exists, remove it
		if (current != null)
		{
			myLList.Remove(current);
		}
	}
}
