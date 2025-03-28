using System;

/// <summary>
/// Modifier enum
/// </summary>
public enum Modifier
{
    Weak,
    Base,
    Strong
}

/// <summary>
/// CalculateModifier delegate
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// CurrentHPArgs class
/// </summary>
class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;

    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

/// <summary>
/// Player class
/// </summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    public delegate void CalculateHealth(float amount);

    public event EventHandler<CurrentHPArgs> HPCheck;

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
        this.status = $"{name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>
    /// Checks and sets player status based on current HP
    /// </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        switch (e.currentHp)
        {
            case float hp when hp == maxHp:
                status = $"{name} is in perfect health!";
                break;
            case float hp when hp >= maxHp / 2 && hp < maxHp:
                status = $"{name} is doing well!";
                break;
            case float hp when hp >= maxHp / 4 && hp < maxHp / 2:
                status = $"{name} isn't doing too great...";
                break;
            case float hp when hp > 0 && hp < maxHp / 4:
                status = $"{name} needs help!";
                break;
            case float hp when hp == 0:
                status = $"{name} is knocked out!";
                break;
        }
        Console.WriteLine(status);
    }

    /// <summary>
    /// Triggers warning messages when HP is very low or zero
    /// </summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Red;

        if (e.currentHp == 0)
            Console.WriteLine("Health has reached zero!");
        else
            Console.WriteLine("Health is low!");

        Console.ResetColor();
    }

    /// <summary>
    /// Calls HPCheck and attaches HPValueWarning if HP is below 25%
    /// </summary>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < maxHp / 4)
            HPCheck += HPValueWarning;

        HPCheck?.Invoke(this, e);
    }

    /// <summary>
    /// Prints player health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Applies damage to player
    /// </summary>
    public void TakeDamage(float damage)
    {
        damage = damage >= 0 ? damage : 0;
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Heals the player
    /// </summary>
    public void HealDamage(float heal)
    {
        heal = heal >= 0 ? heal : 0;
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Validates and sets HP, triggers events
    /// </summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
            hp = 0f;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;

        OnCheckStatus(new CurrentHPArgs(hp));
    }

    /// <summary>
    /// Applies a modifier to a base value
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
