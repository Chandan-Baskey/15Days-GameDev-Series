using System;

class Enemy
{
    public string name;
    public int health;
    public int damge;

    public void Attack()
    {
        Console.WriteLine(name + " attack for " + damge + " damge");
    }
    public void showstats()
    {
        Console.WriteLine("Name" + name);
        Console.WriteLine("Health" + health);
        Console.WriteLine("damge" + damge);
    }
}

class program
{
    static void Main()
    {
        Enemy e = new Enemy();
        e.name = "Goblin";
        e.health = 100;
        e.damge = 40;

        e.showstats();
        e.Attack();
    }
}