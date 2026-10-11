using System;

class Q6
{
    static void Main()
    {
        int playerHp= 100;
        string[] Weapons = {"Sword", "Bow", "Spear", "Axe", "Dagger"};
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Enemy" + i);
        }

        while(playerHp>0)
        {
            Console.WriteLine($"Player HP: {playerHp}");
            playerHp-=20;
        }

        foreach(string items in Weapons)
        {
            Console.WriteLine(items);
        }
    }
}