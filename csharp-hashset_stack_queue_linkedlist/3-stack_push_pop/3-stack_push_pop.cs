using System;
using System.Collections.Generic;

public class MyStack
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

		// Check if the stack contains the search item
		if (aStack.Contains(search))
		{
			Console.WriteLine($"Stack contains \"{search}\": True");
			while (aStack.Contains(search))
				aStack.Pop();
		}
		else
		{
			Console.WriteLine($"Stack contains \"{search}\": False");
		}

		// Add the new item to the stack
		aStack.Push(newItem);
		
		// Return the modified stack
	        return aStack;
	}
}
