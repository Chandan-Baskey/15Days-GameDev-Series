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
        p.health = damage;
        if (p.health < 0) p.health = 0;
        Console.WriteLine(name + " Attack " + p.name + " And Player HP: " + p.health);
    }
}
class Player
{
    public string name;
    public int health;
    public int damage;

    public Player(string n, int h, int d)
    {
        name = n;
        health = h;
        damage = d;
    }

    public void Attack(Enemy e)
    {
        e.health -= damage;
        if (e.health < 0) e.health = 0;
        Console.WriteLine(e.name + "Take Damage " + e.health);
    }
}
class Game
{
    static void Main()
    {
        Player player = new Player("Hero", 100, 25);

        Enemy[] enemise = new Enemy[2];
        enemise[0] = new Enemy("Goblin", 50, 10);
        enemise[1] = new Enemy("Dragon", 100, 20);
        int defected = 0;
        for (int i = 0; i < enemise.Length; i++)
        {
            Enemy e = enemise[i];

            while (e.health > 0 && player.health > 0)
            {
                player.Attack(e);
                if (e.health <= 0)
                {
                    Console.WriteLine(e.name + " Defect");
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
            // if(player.health<=0) 
            //   break;
        }
        Console.WriteLine("Defect: " + defected);
        if (player.health > 0)
            Console.WriteLine("Player survived!");
        else
            Console.WriteLine("Player died!");
    }
}