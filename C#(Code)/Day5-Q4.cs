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

    public void Attack()
    {
        Console.WriteLine(name + " attacks for " + damage + "!"
        + "HP is: " + health);
    }
}
class Game
{
    static void Main()
    {
        Enemy name = new Enemy("Goblin ", 100, 25);
        Enemy name1 = new Enemy("Drogan ", 80, 30);

        name.Attack();
        name1.Attack();
    }
}