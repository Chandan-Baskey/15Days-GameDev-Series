/*
🧩 Q6: Find Strongest Enemy

👉 Given:

[100, 150, 90]

👉 Task:

Find max health enemy
*/

using System;
class Plyer
{
    static void Main()
    {
        int[] enemies = { 200, 45, 300, 10 };
        int Max = 0;
        int Index = 0;

        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i] > Max)
            {
                Index = i;
                Max = enemies[i];
            }
        }
        Console.WriteLine("Enemy No: " + (Index + 1));
        Console.WriteLine("Health: " + Max);
    }
}