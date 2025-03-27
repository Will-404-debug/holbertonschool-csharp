using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>Base class</summary>
abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

/// <summary>Interface for interactive objects</summary>
interface IInteractive
{
    void Interact();
}

/// <summary>Interface for breakable objects</summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>Interface for collectable objects</summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>Door class</summary>
class Door : Base, IInteractive
{
    public Door(string name = "Door")
    {
        this.name = name;
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary>Decoration class</summary>
class Decoration : Base, IInteractive, IBreakable
{
    public int durability { get; set; }
    public bool isQuestItem;

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else
            Console.WriteLine($"The {name} is already broken.");
    }
}

/// <summary>Generic class that implements IEnumerable</summary>
class Objs<T> : IEnumerable<T>
{
    private List<T> _collection = new List<T>();

    public void Add(T item)
    {
        _collection.Add(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _collection.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
