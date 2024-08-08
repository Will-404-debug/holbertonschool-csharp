using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
	{
		// Add a new node with value n at the beginning of the linked list
		myLList.AddFirst(n);

		// Return the newly added node, which is now the first node
		return myLList.First;
	}
}
