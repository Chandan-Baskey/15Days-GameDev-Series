using System;

class VQ4
{
    static void Main()
    {
        System.Console.WriteLine("Enter Your HP");
        int playerHP = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Your mana");
        int playerMana = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Your stamina");
        int playerStamina = int.Parse(Console.ReadLine());

        System.Console.WriteLine("You have any Buffed Power then press 1 and if you don't have Buffed Power then press 0");
        bool isBuffed = int.Parse(Console.ReadLine())==1?true:false;

        int allPower = playerHP + playerMana + playerStamina;
        float averagePower = allPower / 300f * 100;

        if(averagePower>=80 && isBuffed)
        {
            System.Console.WriteLine("You are Strong");
        }
        else if(averagePower>=50 && averagePower<80)
        {
            System.Console.WriteLine("You are Weak");
        }
        else
        {
            System.Console.WriteLine("You are Exhausted");
        }
    }
}