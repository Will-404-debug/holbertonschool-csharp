using System;

/// <summary>
/// Generic Queue class without using System.Collections
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// Returns the type of the generic parameter T
    /// </summary>
    /// <returns>Type of T</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
