using System;

class LQ5
{
    static void Main()
    {
        int bossHP =300;
        int playerHP =200;

        int playerAtk = 45;
        int bossAtk = 0;
        
        int round = 0;

        while(bossHP>0 && playerHP>0)
        {
            round++;

            if(bossHP<100)  bossAtk = 35;
               
            bossHP -= playerAtk;
            playerHP -= bossAtk;    
        }
        
        if(bossHP<=0 && playerHP>0)
        {
            Console.WriteLine("Player Wins");
        }
        else if(playerHP<=0 && bossHP>0)
        {
            Console.WriteLine("Boss Wins");
        }
        else
        {
            Console.WriteLine("Draw");
        }
    }  
}