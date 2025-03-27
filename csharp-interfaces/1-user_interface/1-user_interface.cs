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
public interface IInteractive
{
    void Interact();
}

/// <summary>Interface for breakable objects</summary>
public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>Interface for collectable objects</summary>
public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// TestObject class that inherits Base and implements
/// IInteractive, IBreakable, and ICollectable
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {
        // Not implemented
    }

    public void Break()
    {
        // Not implemented
    }

    public void Collect()
    {
        // Not implemented
    }
}
