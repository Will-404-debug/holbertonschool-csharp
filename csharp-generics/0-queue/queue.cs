using System;

/// <summary>
/// Custom generic Queue class
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// Returns the type of T
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
