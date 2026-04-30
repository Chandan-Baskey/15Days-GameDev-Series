
using System;

class Enemy
{
    public string name;
    public int health;
    public int damage;

    public void Attack()
    {
        Console.WriteLine("Enemy is: " + name + " Health is: " + health + " And Damage: " + damage);
    }
    public void ShowStats()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Health: " + health);
        Console.WriteLine("Damage: " + damage);
    }
}
class GameSystem
{
    static void Main()
    {
        Enemy goblin = new Enemy();
        goblin.name = "Goblin";
        goblin.health = 100;
        goblin.damage = 25;
        goblin.ShowStats();
        goblin.Attack();

        Enemy drogan = new Enemy();
        drogan.name = "Drogan";
        drogan.health = 100;
        drogan.damage = 25;
        drogan.ShowStats();
        drogan.Attack();
    }
}