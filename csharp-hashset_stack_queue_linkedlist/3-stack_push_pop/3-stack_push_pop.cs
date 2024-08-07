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

		// If aStack contains the given item search, remove all items up to and including search
	        if (containsSearch)
                {
			// Use Pop once to get all elements
			Stack<string> tempStack = new Stack<string>();
			bool found = false;

			while (aStack.Count > 0)
                        {
				string item = aStack.Pop();
                                if (item == search)
                                {
					found = true;
				        break;
				}
				tempStack.Push(item);
			}
			
			// Push remaining items back to aStack
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
