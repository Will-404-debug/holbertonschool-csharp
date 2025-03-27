using System;

/// <summary>Base class</summary>
abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

/// <summary>ICollectable interface</summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>Key class inheriting Base and ICollectable</summary>
class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    /// <summary>Constructor</summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>Collect method implementation</summary>
    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}
