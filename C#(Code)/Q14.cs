using System;

class Enemy
{
    public int HP= 100;
}

class Player
{
    static void Main()
    {
        Enemy e1 = new Enemy();
        Enemy p1 = e1;
        p1.HP =75;
        System.Console.WriteLine(e1.HP);
         System.Console.WriteLine(p1.HP);
    }
}