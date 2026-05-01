/*
🎮 Game Logic:
Computer sets number = 7
Player guesses
Show:
 Too High
 Too Low
 Correct
*/

using System;

class Program
{
    static void Main()
    {
        int GuessNub = 7;
        Console.Write("Guess Number");
        int PlayerNum = int.Parse(Console.ReadLine());

        if (PlayerNum < GuessNub)
        {
            Console.WriteLine("Too Low");
        }
        else if (PlayerNum > GuessNub)
        {
            Console.WriteLine("Too High");
        }
        else
        {
            Console.WriteLine("Correct");
        }
    }
}
