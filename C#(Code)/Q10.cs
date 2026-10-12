using System;

class Q10
{
    static void Main(string[] args)
    {
        int[] scores = { 85, 92, 78, 96, 88 };
        Array.Sort(scores);
        int ind = Array.BinarySearch(scores, 78);
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("Score at index " + i + ": " + scores[i]);
        }
        Console.WriteLine("Index of score 78: " + ind);
        // Array.Reverse(scores);
        // for (int i = 0; i < scores.Length; i++)
        // {
        //     Console.WriteLine("Score at index " + i + ": " + scores[i]);
        // }
    }
}