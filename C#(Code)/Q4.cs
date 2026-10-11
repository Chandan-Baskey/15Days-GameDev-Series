using System;

class Q4
{
    static void Main()
    {
        System.Console.WriteLine("Enter your Player Name:");
        string playerName = Console.ReadLine();

        System.Console.WriteLine("Enter Your Player HP:");
        int playerHp = int.Parse(Console.ReadLine());

        if(playerHp >0)
        {
            System.Console.WriteLine($"Player {playerName} is Alive");
        }
        else
        {
            System.Console.WriteLine($"Player {playerName} is Dead");
        }
    }
}