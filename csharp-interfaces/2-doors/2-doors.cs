using System;

/// <summary>
/// Base class
/// </summary>
abstract class Base
{
    /// <summary>Name property</summary>
    public string name { get; set; }

    /// <summary>ToString override</summary>
    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}

/// <summary>Interface for interactive objects</summary>
interface IInteractive
{
    void Interact();
}

/// <summary>Door class that inherits Base and IInteractive</summary>
class Door : Base, IInteractive
{
    /// <summary>Constructor sets name (default = "Door")</summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>Interact implementation</summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
