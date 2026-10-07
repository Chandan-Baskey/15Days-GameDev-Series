using System;

class LQ2
{
    static void Main()
    {
        int counter = 0;
        int playerHp = 40;
        while(playerHp <= 100)
        {
            System.Console.WriteLine("Player HP is " + playerHp);
            playerHp += 5;
            counter++;
        }
        System.Console.WriteLine("100 reached in:" + counter + " Seconds");
    }
}