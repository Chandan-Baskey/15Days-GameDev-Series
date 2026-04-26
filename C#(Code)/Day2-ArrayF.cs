using System;
class Program
{
    static void Main()
    {
        string[] weapons = { "Sword", "Bow", "Staff", "Dagger" };

        for (int i = 0; i < weapons.Length; i++) // for loop
        {
            Console.WriteLine("weapons" + (i + 1) + ":" + weapons[i]);
        }

        foreach (string w in weapons) // foreach loop
        {
            Console.WriteLine(w);
        }
    }
}