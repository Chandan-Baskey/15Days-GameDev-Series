using System;

class Program1
{
    static void Main()
    {
        int playerHP = 100;
        playerHP -=35;
        playerHP +=20;

        if (playerHP >30)
        {
            Console.WriteLine("IsAlive");
        }
        else
        {
            Console.WriteLine("Die");
        }
    }
}

