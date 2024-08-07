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
			Console.WriteLine($"Top item: {aStack.Peek()}");
		}
		else
		{
			Console.WriteLine("Stack is empty");
		}
		
		// Print if aStack contains a given item search
		bool containsSearch = aStack.Contains(search);
		Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");

		// Remove items up to and including the search item if it exists
		if (containsSearch)
                {
			Stack<string> tempStack = new Stack<string>();
			while (aStack.Count > 0)
			{
				string topItem = aStack.Pop();
				if (topItem == search)
				{
					break;
				}
				tempStack.Push(topItem);
			}
			
			// Put the remaining items back in the original stack
			while (tempStack.Count > 0)
			{
				aStack.Push(tempStack.Pop());
			}
		}

		// Add a new item to the stack
		aStack.Push(newItem);

		// Return the modified stack
		return aStack;
	}
}
