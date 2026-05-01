using System;
class Program
{
    static void Main()
    {
        Console.Write("Player Health: ");
        int health = int.Parse(Console.ReadLine());

        switch (health)
        {
            case 0:
                Console.WriteLine("Game Over!");
                break;
            default:
                Console.WriteLine("Health is above 0!");
                break;
        }
    }
}