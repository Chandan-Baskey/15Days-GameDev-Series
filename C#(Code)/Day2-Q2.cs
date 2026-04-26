using System;
using System.Collections.Generic;


class Program
{
    static void ShootEnemy(int damge, int[] enemy)
    {
        for (int i = 0; i < enemy.Length; i++)
        {
            enemy[i] -= damge;
            Console.WriteLine("Enemy: " + (i + 1) + "Health: " + enemy[i]);
        }
    }

    static void Main()
    {
        int[] enemy = { 30, 10, 50 };
        Console.WriteLine("Ender Your Damage: ");
        int damge = int.Parse(Console.ReadLine());
        ShootEnemy(damge, enemy);

    }
}