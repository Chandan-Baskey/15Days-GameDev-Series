
using System;

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
        Enemy enemy = new Enemy("Goblin", 80, 40);
        //Enemy enemy = new Enemy("Orc", 80, 20);

        while (enemy.health > 0 && player.health > 0)
        {
            player.Attack(enemy);
            if (enemy.health <= 0)
            {
                Console.WriteLine(enemy.name + " Destroyed");
                break;
            }

            enemy.Attack(player);
            if (player.health <= 0)
            {
                Console.WriteLine("Game Over");
                break;
            }
        }
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