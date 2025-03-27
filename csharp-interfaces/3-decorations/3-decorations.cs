using System;

/// <summary>Base class</summary>
abstract class Base
{
    /// <summary>Name property</summary>
    public string name { get; set; }

    /// <summary>ToString override</summary>
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

/// <summary>Decoration class</summary>
class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>Durability of the object</summary>
    public int durability { get; set; }

    /// <summary>Whether it’s a quest item</summary>
    public bool isQuestItem;

    /// <summary>Constructor for Decoration</summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>Interact implementation</summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    /// <summary>Break implementation</summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}
