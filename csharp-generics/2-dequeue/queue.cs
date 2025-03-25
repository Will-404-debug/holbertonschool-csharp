using System;

/// <summary>Generic Queue class</summary>
class Queue<T>
{
    /// <summary>Head of the queue</summary>
    public Node head = null;

    /// <summary>Tail of the queue</summary>
    public Node tail = null;

    /// <summary>Number of elements in the queue</summary>
    public int count = 0;

    /// <summary>Node class representing each element in the queue</summary>
    public class Node
    {
        /// <summary>Value stored in the node</summary>
        public T value = default(T);

        /// <summary>Reference to the next node</summary>
        public Node next = null;

        /// <summary>Constructor to initialize node with a value</summary>
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    /// <summary>Returns the type of objects stored in the queue</summary>
    /// <returns>The Type of T</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>Adds a new node containing value to the end of the queue</summary>
    /// <param name="value">Value to enqueue</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        count++;
    }

    /// <summary>Returns the number of nodes in the queue</summary>
    /// <returns>Count of nodes</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Removes the first node and returns its value
    /// </summary>
    /// <returns>Value of the removed node or default if empty</returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.value;

        head = head.next;
        count--;

        if (head == null)
        {
            tail = null;
        }

        return value;
    }
}
