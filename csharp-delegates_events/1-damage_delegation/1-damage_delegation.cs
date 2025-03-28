using System;

/// <summary> Delegate that takes a float amount. </summary>
public delegate void CalculateHealth(float amount);

class Player
{
    private string name;
    private float maxHp;
    private float hp;

    // Constructor
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;

        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
        {
            this.maxHp = maxHp;
        }

        this.hp = this.maxHp;
    }

    // PrintHealth method
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    // TakeDamage method
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
            damage = 0f;

        Console.WriteLine($"{this.name} takes {damage} damage!");
        // You can implement logic to subtract from hp later
    }

    // HealDamage method
    public void HealDamage(float heal)
    {
        if (heal < 0f)
            heal = 0f;

        Console.WriteLine($"{this.name} heals {heal} HP!");
        // You can implement logic to add to hp later
    }
}
