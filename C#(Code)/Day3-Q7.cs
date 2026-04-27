/*
Q7: Guess the Number (Max 5 Attempts)

👉 Task:

Guess the number between 1 to 10.
You have only 5 attempts.
If correct → print "Correct! You guessed it."
If wrong → print remaining attempts.
If attempts end → print "Game Over."
*/

using System;
using System.Collections.Generic;
class Plyer
{
    static void Main()
    {
        Console.WriteLine("----Max 5 Attempts----");
        int guess = 5;
        int Max = 5;
        int count = 1;
        while (Max > 0)
        {
            Console.WriteLine("Enter Guess No: ");
            int Num = int.Parse(Console.ReadLine());
            if (guess == Num)
            {
                Console.WriteLine("Correct! You guessed it.");
                break;
            }
            else
            {
                Console.WriteLine(count + " Attempts left");
                Max -= 1;
                count += 1;
            }
            if (Max == 0)
                Console.WriteLine("Game Over");
        }
    }
}