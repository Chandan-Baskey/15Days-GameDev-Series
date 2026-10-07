using System;

class Program
{
    static void Main(string[] args)
    {
        int playerHP = 100;
        
        playerHP -= 20; 
        playerHp+=10;

        if(playerHP<30)
        {
            Console.WriteLine("IsAlive");
        }

        else
        {
            Console.WriteLine("Die");
        }
    }
}

