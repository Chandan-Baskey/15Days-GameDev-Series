using System;
using System.Collections.Generic;

class Q11
{
    static void Main(string[] args)
    {
        List<int> scores = new List<int>();
        scores.Add(85);
        scores.Add(92);
        scores.Add(78);
        scores.Add(96);
        scores.Add(88);
        Console.WriteLine(scores.Count);
        scores.RemoveAt(0);
        bool has = scores.Contains(92);
        int idx = scores.IndexOf(96);
        Console.WriteLine(has);
        Console.WriteLine(idx);
         Console.WriteLine(scores.Count);
        List<string> names = new List<string>{ "Goblin", "Orc", "Dragon"};
        for(int i = 0; i<scores.Count; i++)
        {
            Console.WriteLine("Score at index " + i + ": " + scores[i]);
        }
    }
}