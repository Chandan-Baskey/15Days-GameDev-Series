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
        int secretNumber = 7; // you can randomize later
        int maxAttempts = 5;
        int attempts = 0;
        bool isGuessed = false;
        while (attempts < maxAttempts && !isGuessed)
        {
            Console.WriteLine("Enter your guess:");
            int guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess == secretNumber)
            {
                Console.WriteLine("Correct! You guessed it.");
                isGuessed = true;
            }
            else
            {
                Console.WriteLine("Wrong guess.");
                int attemptsLeft = maxAttempts - attempts;
                Console.WriteLine("Attempts left: " + attemptsLeft);
            }
        }
        if (!isGuessed)
        {
            Console.WriteLine("Game Over! The number was: " + secretNumber);
        }
    }
}