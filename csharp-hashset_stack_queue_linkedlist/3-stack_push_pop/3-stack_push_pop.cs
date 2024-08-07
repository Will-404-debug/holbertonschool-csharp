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
			// Use Pop once to get all elements
			List<string> tempList = new List<string>();
			tempList.Add(aStack.Pop());
			
			while (aStack.Count > 0)
			{
				tempList.Add(aStack.Peek());
				aStack.Pop();
				if (tempList[tempList.Count - 1] == search)
				{
					break;
				}
			}
			
			// Push remaining items back to aStack
			for (int i = tempList.Count - 1; i >= 0; i--)
		        {
				if (tempList[i] == search)
				{
					break;
				}
				aStack.Push(tempList[i]);
			}
		}
		
		// Add a new given item newItem to aStack
		aStack.Push(newItem);
		
		// Return the modified stack
		return aStack;
	}
}
