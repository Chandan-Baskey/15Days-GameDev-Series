using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int target = a[0];

        for (int i = 1; i < n; i++)
        {
            target = Math.Min(target, a[i]);
        }

        int steps = 0;

        for (int i = 0; i < n; i++)
        {
            int diff = a[i] - target;


            if (diff == 0)
                continue;

            if (b[i] == 0 || diff % b[i] != 0)
            {
                Console.WriteLine(-1);
                return;
            }

            steps += diff / b[i];
        }

        Console.WriteLine(steps);
    }
}