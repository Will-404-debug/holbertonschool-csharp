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
		}

		// Print if aStack contains a given item search
		bool containsSearch = aStack.Contains(search);
		Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");

		// If aStack contains the given item search, remove all items up to and including search
		if (containsSearch)
		{
			Stack<string> tempStack = new Stack<string>();
			while (aStack.Count > 0)
			{
				string item = aStack.Pop();
				if (item == search)
				{
					break;
				}
				tempStack.Push(item);
			}
			// Restore the items back to the original stack except the removed ones
			while (tempStack.Count > 0)
			{
				aStack.Push(tempStack.Pop());
			}
		}
		
		// Add a new given item newItem to aStack
		aStack.Push(newItem);

		// Return the modified stack
		return aStack;
	}
}
