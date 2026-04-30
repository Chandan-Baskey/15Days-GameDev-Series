// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

class Enemy
{
    public string name;
    public int health;
    public int damage;

    public Enemy(string n, int h, int d)
    {
        name = n;
        health = h;
        damage = d;
    }
    public void Attack(Player p)
    {
        p.health -= damage;
        if (p.health < 0) p.health = 0;
        Console.WriteLine(name + " attacks Player! Player health: " + p.health);
    }
}

class Player
{
    public int health = 100;
    public void Attack(Enemy e)
    {
        e.health -= 20;
        if (e.health < 0) e.health = 0;
        Console.WriteLine(e.name + " takes damage " + e.health);
    }
}
class Game
{
    static void Main()
    {
        Player player = new Player();
        List<Enemy> enemies = new List<Enemy>()
        {
            new Enemy("Goblin", 50, 10),
            new Enemy("Orc", 80, 20),
            new Enemy("Dragon", 120, 30)
        };

        int defected = 0;
        foreach (Enemy e in enemies)
        {
            while (e.health > 0 && player.health > 0)
            {
                player.Attack(e);
                if (e.health <= 0)
                {
                    Console.WriteLine(e.name + " Destroyed");
                    defected++;
                    break;
                }

                e.Attack(player);
                if (player.health <= 0)
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }
        Console.WriteLine("Player Defect: " + defected);
        if (player.health > 0)
        {
            Console.WriteLine("Player Win");
        }
        else
        {
            Console.WriteLine("Enemy Win");
        }
    }
}