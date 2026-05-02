using System;

class Program
{
    static void Main()
    {
        int health =100;
        Console.Write("Enemy Damage");
        int damage = int.Parse(Console.ReadLine());
        health = health - damage;
        Console.WriteLine("You health is :"+health);
        
    }   
}
