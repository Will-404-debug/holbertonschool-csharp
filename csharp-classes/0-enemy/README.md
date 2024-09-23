e Class in Enemies Namespace

## Description

This project defines a `Zombie` class within the `Enemies` namespace. The class is currently empty and serves as a basic starting point for further development. The purpose of this task is to establish a basic structure for defining enemies in a game context.

## Project Structure

The project consists of the following files:

- `0-enemy.cs`: Defines the `Zombie` class in the `Enemies` namespace.
- `0-main.cs`: A test file used to create an instance of the `Zombie` class and verify its type.
- `0-enemy.csproj`: Project file to configure and build the project using .NET.

### Class Description

- **Namespace**: `Enemies`
- **Class**: `Zombie`

The `Zombie` class is currently an empty class, defined with the intention of being expanded in the future.

### Example Usage

The following example demonstrates creating a `Zombie` object and verifying its type and string representation:

```csharp
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();

        Console.WriteLine("newObject is of type {0}", newObject.GetType());
        Console.WriteLine("String representation: {0}", newObject.ToString());
    }
}
