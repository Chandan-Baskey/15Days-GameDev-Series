using System;

class Player
{
    public string name;
    public int health;
    public int MaxHealth = 100;

    public Player(string n, int h)
    {
        name = n;
        health = h;
    }

    public void TakeDamage(int dam)
    {
        health -= dam;
        if (health < 0) health = 0;
        Console.WriteLine(name + " Take Damge: " + dam + "HP : " + health);
    }

    public void Heal(int amount)
    {
        health += amount;
        if (health > MaxHealth) health = MaxHealth;
        Console.WriteLine("Heal: " + amount + " Total HP: " + health);
    }

    public bool IsAlive()
    {
        return health > 0;
    }
}

class Game
{
    static void Main()
    {
        Player name1 = new Player("hero", 100);
        name1.TakeDamage(35);
        name1.Heal(25);
        if (name1.IsAlive())
        {
            Console.WriteLine("Is Alive");
        }
        else
            Console.WriteLine("Not Alive");
    }
}
