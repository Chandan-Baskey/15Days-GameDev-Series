using System;

class Program
{
    static void Main()
    {
        Console.Write("Player Health: ");
        int health = int.Parse(Console.ReadLine());

        if(health<=0)
        {
            Console.WriteLine("Game Over!");
        }
        else
        {
            Console.WriteLine("Health is above 0!");
        }
    }
}