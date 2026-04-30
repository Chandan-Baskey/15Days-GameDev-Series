using System;

// ════════════════════════════════
//  PLAYER CLASS
// ════════════════════════════════
class Player
{
    public string name;
    public int health;
    public int damage;

    // Constructor
    public Player(string n, int h, int d)
    {
        name = n;
        health = h;
        damage = d;
    }

    // Take damage — health never goes below 0
    public void TakeDamage(int dmg)
    {
        health -= dmg;
        if (health < 0) health = 0;
    }

    // Returns true if still alive
    public bool IsAlive()
    {
        return health > 0;
    }

    // Print current stats
    public void ShowStats()
    {
        Console.WriteLine("  [PLAYER] " + name
                        + "  HP: " + health
                        + "  DMG: " + damage);
    }
}

// ════════════════════════════════
//  ENEMY CLASS
// ════════════════════════════════
class Enemy
{
    public string name;
    public int health;
    public int damage;

    // Constructor
    public Enemy(string n, int h, int d)
    {
        name = n;
        health = h;
        damage = d;
    }

    // Take damage
    public void TakeDamage(int dmg)
    {
        health -= dmg;
        if (health < 0) health = 0;
    }

    // Returns true if still alive
    public bool IsAlive()
    {
        return health > 0;
    }

    // Attack a player object
    public void Attack(Player p)
    {
        Console.WriteLine("  " + name + " attacks "
                        + p.name + " for " + damage + " damage!");
        p.TakeDamage(damage);
    }
}

// ════════════════════════════════
//  MAIN
// ════════════════════════════════
class Program
{
    static void Main()
    {
        // Create player and enemy
        Player hero = new Player("Hero", 100, 25);
        Enemy dragon = new Enemy("Dragon", 120, 20);

        Console.WriteLine("╔══════════════════════════╗");
        Console.WriteLine("║      BATTLE START!       ║");
        Console.WriteLine("╚══════════════════════════╝");
        hero.ShowStats();
        dragon.ShowStats();  // just using same format manually
        Console.WriteLine("  [ENEMY]  " + dragon.name
                        + "  HP: " + dragon.health
                        + "  DMG: " + dragon.damage);

        int round = 1;

        // Battle loop
        while (hero.IsAlive() && dragon.IsAlive())
        {
            Console.WriteLine("\n--- ROUND " + round + " ---");

            // Player attacks enemy
            Console.WriteLine("  " + hero.name + " attacks "
                            + dragon.name + " for "
                            + hero.damage + " damage!");
            dragon.TakeDamage(hero.damage);

            // Enemy attacks player (only if still alive)
            if (dragon.IsAlive())
            {
                dragon.Attack(hero);
            }

            // Print HP after round
            Console.WriteLine("  >> " + hero.name
                            + " HP: " + hero.health);
            Console.WriteLine("  >> " + dragon.name
                            + " HP: " + dragon.health);

            round++;
        }

        // Declare winner
        Console.WriteLine("\n╔══════════════════════════╗");
        Console.WriteLine("║        RESULT!           ║");
        Console.WriteLine("╚══════════════════════════╝");

        if (hero.IsAlive())
        {
            Console.WriteLine("  WINNER: " + hero.name
                            + " wins! Remaining HP: " + hero.health);
        }
        else
        {
            Console.WriteLine("  WINNER: " + dragon.name
                            + " wins! " + hero.name + " has fallen!");
        }
    }
}