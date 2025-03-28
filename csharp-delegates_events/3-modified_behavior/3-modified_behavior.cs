using System;

/// <summary>
/// Modifier enum
/// </summary>
public enum Modifier
{
    /// <summary> Weak modifier</summary>
    Weak,
    /// <summary> Base modifier</summary>
    Base,
    /// <summary> Strong modifier</summary>
    Strong
}

/// <summary>
/// CalculateModifier delegate
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Player class
/// </summary>
class Player
{
    /*player name*/
    private string name;
    /*player max hp*/
    private float maxHp;
    /*player hp*/
    private float hp;

    /// <summary> CalculateHealth delegate</summary>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Player constructor
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.hp = this.maxHp;
    }

    /// <summary>
    /// Print player health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Take damage method
    /// </summary>
    public void TakeDamage(float damage)
    {
        damage = damage >= 0 ? damage : 0;
        Console.WriteLine("{0} takes {1} damage!", name, damage);
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Heal damage method
    /// </summary>
    public void HealDamage(float heal)
    {
        heal = heal >= 0 ? heal : 0;
        Console.WriteLine("{0} heals {1} HP!", name, heal);
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Validate and set hp
    /// </summary>
    public void ValidateHP(float newHp)
    {
        switch (newHp)
        {
            case float health when health < 0:
                hp = 0;
                break;
            case float health when health > maxHp:
                hp = maxHp;
                break;
            default:
                hp = newHp;
                break;
        }
    }

    /// <summary>
    /// ApplyModifier method
    /// </summary>
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
