using System;
using System.Collections.Generic;
class Plyer
{
    static void Main()
    {
        List<int> enemy = new List<int>();
        enemy.Add(100);
        enemy.Add(170);
        enemy.Add(190);
        enemy.Add(200);
        Console.WriteLine(enemy[0]);

        foreach (int w in enemy)
        {
            Console.WriteLine(w);
        }
    }
}