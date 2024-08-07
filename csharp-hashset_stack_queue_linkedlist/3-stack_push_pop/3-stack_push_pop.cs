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
		
		// Check if the stack contains the given item
		bool containsSearch = aStack.Contains(search);
		Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");
		
		// If the stack contains the search item, remove items up to and including the search item using only one Pop
		if (containsSearch)
		{
			List<string> tempList = new List<string>();
			while (aStack.Count > 0)
			{
				string topItem = aStack.Pop();
	                        tempList.Add(topItem);
	                        if (topItem == search)
	                        {
					break;
				}
			}
			// Push the items back into the stack except the removed items
	                tempList.Reverse();
	                foreach (var item in tempList)
	                {
				if (item != search)
	                        {
					aStack.Push(item);
	                        }
			}
		}
		// Add the new item to the stack
		aStack.Push(newItem);
		
		// Return the modified stack
	        return aStack;
	}
}
