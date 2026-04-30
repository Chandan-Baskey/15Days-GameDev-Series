
using System;
class Player
{
    public string name;
    public int health;
    public int maxHealth = 100;

    public Player(string n)
    {
        name = n;
        health = 100;
    }

    public void TakeDamge(int dam)
    {
        health -= dam;
        if (health < 0) health = 0;

        Console.WriteLine(name + "took " + dam + "damge HP" + health);
    }

    public void Heal(int amount)
    {
        health += amount;
        if (health > maxHealth) health = maxHealth;
        Console.WriteLine(name + "health Hp " + health);
    }
    public bool IsAlive()
    {
        return health > 0;
    }
}
class GameSystem
{
    static void Main()
    {
        Player hero = new Player("Hero");
        hero.TakeDamge(30);
        hero.TakeDamge(25);

        if (hero.IsAlive())
            Console.WriteLine("Player Aline");
        else
            Console.WriteLine("Player die");

    }
}