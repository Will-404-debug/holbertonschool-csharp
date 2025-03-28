﻿using System;

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
/// CurrentHPArgs class
/// </summary>
class CurrentHPArgs : EventArgs
{
    /// <summary>current hp</summary>
    public readonly float currentHp;

    /// <summary>
    /// CurrentHPArgs constructor
    /// </summary>
    /// <param name="newHp"></param>
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
    /*player name*/
    private string name;
    /*player max hp*/
    private float maxHp;
    /*player hp*/
    private float hp;
    /*player status*/
    private string status;

    /// <summary> CalculateHealth delegate</summary>
    public delegate void CalculateHealth(float amount);

    /// <summary> HPCheck event</summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// player constructor
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
        this.status = $"{name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>
    /// Check and update player status based on current HP
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
    /// Validate and clamp new HP
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

        HPCheck?.Invoke(this, new CurrentHPArgs(hp));
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
