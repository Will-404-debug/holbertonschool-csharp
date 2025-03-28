/// <summary>
/// Player class
/// </summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    /// <summary> CalculateHealth delegate </summary>
    public delegate void CalculateHealth(float amount);

    /// <summary> HPCheck event </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// Player constructor
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;

        if (maxHp <= 0f)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }

        this.hp = this.maxHp;
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
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
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Heal damage method
    /// </summary>
    public void HealDamage(float heal)
    {
        heal = heal >= 0 ? heal : 0;
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Validate and set HP
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
    /// Call HPCheck event
    /// </summary>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (HPCheck != null)
            HPCheck(this, e);
    }

    /// <summary>
    /// Check and update status
    /// </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        float hpRatio = e.currentHp / maxHp;

        if (e.currentHp == maxHp)
        {
            status = $"{name} is in perfect health!";
        }
        else if (hpRatio >= 0.5f)
        {
            status = $"{name} is doing well!";
        }
        else if (hpRatio >= 0.25f)
        {
            status = $"{name} isn't doing too great...";
        }
        else if (e.currentHp > 0f)
        {
            status = $"{name} needs help!";
        }
        else
        {
            status = $"{name} is knocked out!";
        }

        Console.WriteLine(status);
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
