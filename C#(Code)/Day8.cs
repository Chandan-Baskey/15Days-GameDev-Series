using System;

public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();

        int z = 0;
        int o = 0;

        // Count z and o
        foreach (char c in s)
        {
            if (c == 'z')
                z++;
            else if (c == 'o')
                o++;
        }

        // Check condition
        if (2 * z == o)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}