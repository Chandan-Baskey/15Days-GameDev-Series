using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter Score");
        int score = int.Parse(Console.ReadLine());

        while (score >= 0)
        {
            Console.WriteLine(score);
            score -= 10;
        }

        for(int i=1 ; i<5 ; i++)
        {
            Console.WriteLine("Player Spawn" + i);
        }

    }
}