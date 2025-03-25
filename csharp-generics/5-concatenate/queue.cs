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
        public T value = default(T);
        public Node next = null;

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    public Type CheckType()
    {
        return typeof(T);
    }

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

    public int Count()
    {
        return count;
    }

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
            tail = null;

        return value;
    }

    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.value;
    }

    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }

    /// <summary>Concatenates values if queue contains strings or chars</summary>
    /// <returns>Concatenated string or null</returns>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        Type type = typeof(T);
        if (type != typeof(string) && type != typeof(char))
        {
            Console.WriteLine("Concatenate is for a queue of Strings or Chars only.");
            return null;
        }

        Node current = head;
        string result = "";

        while (current != null)
        {
            if (type == typeof(string))
                result += current.value + (current.next != null ? " " : "");
            else
                result += current.value;

            current = current.next;
        }

        return result;
    }
}
