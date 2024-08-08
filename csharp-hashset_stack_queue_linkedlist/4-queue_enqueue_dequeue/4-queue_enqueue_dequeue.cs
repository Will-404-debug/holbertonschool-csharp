using System;
using System.Collections.Generic;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
		// Print the number of items in the queue
		Console.WriteLine($"Number of items: {aQueue.Count}");

		// Print the first item in the queue without removing it
		if (aQueue.Count > 0)
		{
			Console.WriteLine($"First item: {aQueue.Peek()}");
		}
		else
		{
			Console.WriteLine("Queue is empty");
		}

		// Add the new item to the queue
		aQueue.Enqueue(newItem);

		// Check if the queue contains the search item
		if (aQueue.Contains(search))
		{
			Console.WriteLine($"Queue contains \"{search}\": True");
			while (aQueue.Contains(search))
				aQueue.Dequeue();
		}
		else
		{
			Console.WriteLine($"Queue contains \"{search}\": False");
		}

		// Return the modified queue
		return aQueue;
	}
}
