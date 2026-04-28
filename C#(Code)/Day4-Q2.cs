using System;

class Player
{
    public int health = 100;

    public void Attack(Enemy enemy)
    {
        enemy.health -= 20;
        Console.WriteLine("Enemy Health " + enemy.health);
    }

}

class Enemy
{
    public int health = 80;

}

class GameSystem
{
    static void Main()
    {
        Player p = new Player();
        Enemy e = new Enemy();

        while (e.health > 0)
        {
            p.Attack(e);
            if (e.health <= 0)
            {
                Console.WriteLine("Enemy Destroyed");
            }
        }

    }
}