using System;

/// <summary> Modifier enum. </summary>
public enum Modifier
{
    Weak,
    Base,
    Strong
}

/// <summary> Delegate for calculating a modified value. </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

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
        float newHp = this.hp - damage;
        ValidateHP(newHp);
    }

    // HealDamage method
    public void HealDamage(float heal)
    {
        if (heal < 0f)
            heal = 0f;

        Console.WriteLine($"{this.name} heals {heal} HP!");
        float newHp = this.hp + heal;
        ValidateHP(newHp);
    }

    // ValidateHP method
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
        {
            this.hp = 0f;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }

    // ApplyModifier method matching the delegate
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return baseValue;
        }
    }
}
