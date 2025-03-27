﻿using System;

/// <summary>
/// Abstract class Base with a public property 'name'
/// and an overridden ToString method.
/// </summary>
abstract class Base
{
    /// <summary>
    /// Public string property
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Override ToString to return "<name> is a <type>"
    /// </summary>
    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}
