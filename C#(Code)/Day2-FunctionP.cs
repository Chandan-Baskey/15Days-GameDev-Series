using System;
class Program
{
    static void Shoot(string name, int hp)
    {
        Console.WriteLine(name + " PlayerSpawn " + "With " + hp + " HP! ");
    }
    static void Main()
    {
        Shoot("Unique", 100);
        Shoot("Alex", 50);
    }
}