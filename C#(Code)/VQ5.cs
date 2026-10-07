using System;

class Q1
{
    static void Main()
    {
        int EnemyHP = 80;
        int Damage = 30;
        int FireDamage = 20;

        EnemyHP = EnemyHP - Damage - FireDamage;
        
        Console.WriteLine("Enemy HP is " + EnemyHP);
        
    }
}