using System;

/// <summary>
/// Custom generic Queue class
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// Node class inside Queue
    /// </summary>
    public class Node
    {
        public T value;
        public Node next;

        public Node(T val)
        {
            value = val;
            next = null;
        }
    }

    public Node head;
    public Node tail;
    public int count;

    /// <summary>
    /// Adds a new node at the end of the queue
    /// </summary>
    public void Enqueue(T item)
    {
        Node newNode = new Node(item);

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

    /// <summary>
    /// Returns the number of nodes in the queue
    /// </summary>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Returns the type of the Queue
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
