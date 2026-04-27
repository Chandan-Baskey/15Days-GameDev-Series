/*Q6: Remove Dead Enemies

👉 Given:

[100, 0, 50, 0, 80]

👉 Task:

Remove enemies with health = 0
*/


using System;
using System.Collections.Generic;
class Plyer
{
    static void Main()
    {
        int[] enemy = { 100, 0, 50, 0, 80 };
        List<int> enemyHp = new List<int>();

        foreach (int hp in enemy)
        {
            if (hp != 0)
                enemyHp.Add(hp);
        }
        foreach (int hp in enemyHp)
        {
            Console.WriteLine(hp);
        }
    }
}