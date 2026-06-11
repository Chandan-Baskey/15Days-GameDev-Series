using System;

class Solution
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        while (T-- > 0)
        {
            string[] costs = Console.ReadLine().Split();
            int g = int.Parse(costs[0]);
            int p = int.Parse(costs[1]);

            int n = int.Parse(Console.ReadLine());

            int problem1Solved = 0;
            int problem2Solved = 0;

            for (int i = 0; i < n; i++)
            {
                string[] status = Console.ReadLine().Split();

                problem1Solved += int.Parse(status[0]);
                problem2Solved += int.Parse(status[1]);
            }

            int cost1 = problem1Solved * g + problem2Solved * p;
            int cost2 = problem1Solved * p + problem2Solved * g;

            Console.WriteLine(Math.Min(cost1, cost2));
        }
    }
}