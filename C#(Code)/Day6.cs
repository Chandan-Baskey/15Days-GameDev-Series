using System;

public class Program
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            string[] nm = Console.ReadLine().Split();
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            char[][] grid = new char[n][];

            for (int i = 0; i < n; i++)
            {
                grid[i] = Console.ReadLine().ToCharArray();
            }

            int maxBorder = 0;

            // Check rows
            for (int i = 0; i < n; i++)
            {
                int count = 0;

                for (int j = 0; j < m; j++)
                {
                    if (grid[i][j] == '#')
                    {
                        count++;
                        maxBorder = Math.Max(maxBorder, count);
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }

            // Check columns
            for (int j = 0; j < m; j++)
            {
                int count = 0;

                for (int i = 0; i < n; i++)
                {
                    if (grid[i][j] == '#')
                    {
                        count++;
                        maxBorder = Math.Max(maxBorder, count);
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }

            Console.WriteLine(maxBorder);
        }
    }
}
