using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		// Create a new node
		LinkedListNode<int> newNode = new LinkedListNode<int>(n);

		// If the list is empty, add the new node as the first node
		if (myLList.First == null)
		{
			myLList.AddFirst(newNode);
			return newNode;
		}

		// Traverse the list to find the correct position
		LinkedListNode<int> current = myLList.First;
		while (current != null)
		{
			// If the new value should be inserted before the current node
			if (n < current.Value)
			{
				myLList.AddBefore(current, newNode);
				return newNode;
			}
			current = current.Next;
		}

		// If the new value is greater than all existing values, add it at the end
		myLList.AddLast(newNode);
		return newNode;
	}
}
