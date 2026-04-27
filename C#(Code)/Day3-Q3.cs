/*
🧩 Q3: Enemy Health Update

👉 Given:

[100, 80, 60]

👉 Task:

Reduce each by 20
Print updated health
*/


using System;
class Plyer
{
    static void Main()
    {
        int[] enemiesHealth = { 20, 67, 49 };
        for (int i = 0; i < enemiesHealth.Length; i++)
        {
            enemiesHealth[i] -= 20;
            Console.WriteLine(enemiesHealth[i]);
        }

    }
}