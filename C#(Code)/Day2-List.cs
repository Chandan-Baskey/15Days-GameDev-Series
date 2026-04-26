using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> enemies = new List<int>(); // List

        enemies.Add(103); // Add
        enemies.Add(104);
        enemies.Add(106);
        Console.WriteLine(enemies[0]);
        Console.WriteLine(enemies[1]);
        Console.WriteLine(enemies[2]);
        Console.WriteLine("INDEX:" + enemies.Count); // Count means how many data 

        enemies.Remove(106);
        Console.WriteLine("REMOVE 1 INDEX:" + enemies.Count);

        Console.WriteLine(" ");

        if (enemies.Contains(104)) // Contains means Check data is exist or not 
        {
            Console.WriteLine("IT IS HERE");
        }

        Console.WriteLine(" ");

        foreach (int num in enemies) // foreach loop 
        {
            Console.WriteLine(num);
        }
    }
}