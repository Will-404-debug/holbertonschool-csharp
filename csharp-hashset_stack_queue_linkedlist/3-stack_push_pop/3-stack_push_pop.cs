using System;
using System.Collections.Generic;

class MyStack
{
	public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
	{
		// Print the number of items in aStack
		Console.WriteLine($"Number of items: {aStack.Count}");

		// Print the item at the top of aStack without removing it
		if (aStack.Count > 0)
		{
			string topItem = aStack.Peek();
			Console.WriteLine($"Top item: {topItem}");
		}
		else
		{
			Console.WriteLine("Stack is empty");
			// Since the stack is empty, add newItem and return
			aStack.Push(newItem);
			return aStack;
		}
		
		// Print if aStack contains a given item search
		bool containsSearch = aStack.Contains(search);
		Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");

		// Temporary list to hold the stack elements
		List<string> tempList = new List<string>();

		// If aStack contains the given item search, remove all items up to and including search
	        if (containsSearch)
                {
			// Pop all elements into tempLis once
			string poppedItem = aStack.Pop();
			tempList.Add(poppedItem);
			while (poppedItem != search)
			{
				if (aStack.Count > 0)
				{
					poppedItem = aStack.Peek();
					tempList.Add(aStack.Pop());
				}
				else
				{
					break;
				}
			}
		}
		
		// Push back the remaining items (if any) from tempList to aStack
		for (int i = tempList.Count - 2; i >= 0; i--)
		{
			aStack.Push(tempList[i]);
		}

		// Add a new given item newItem to aStack
		aStack.Push(newItem);

		// Return the modified stack
		return aStack;
	}
}
