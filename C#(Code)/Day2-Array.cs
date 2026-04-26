using System;
class Program
{
    static void Main()
    {
        int[] enemies = { 10, 20, 30 };
        Console.WriteLine(enemies[0]);
        Console.WriteLine(enemies[1]);
        Console.WriteLine(enemies[2]);

        Console.WriteLine("Array Length: " + enemies.Length); // Array Length
        Console.WriteLine("");

        for (int i = 0; i < enemies.Length; i++) // for loop
        {
            Console.WriteLine(i + " Index");
            Console.WriteLine("Value " + enemies[i]);
        }

        enemies[0] = 50;
        Console.WriteLine("");
        Console.WriteLine("replace Index 0 Value: " + enemies[0]); // replace Index Value
    }
}