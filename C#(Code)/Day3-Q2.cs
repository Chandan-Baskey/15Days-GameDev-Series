/*
🧩 Q2: Score Check

👉 Input:

Player score

👉 Task:

If score ≥ 100 → "Level Up"
Else → "Keep Playing"
*/


using System;
class Plyer
{
    static void Main()
    {
        int score = 0;
        Console.WriteLine("Enter Your Score:");
        score = int.Parse(Console.ReadLine());
        if (score >= 100)
            Console.WriteLine("Level Up");
        else
            Console.WriteLine("Keep Play");

    }
}