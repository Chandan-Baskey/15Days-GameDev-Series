using System;

class LQ3
{
    static void Main()
    {
        string[] enemies = {"Alive", "Die", "Alive", "Die", "Alive", "Die", "Alive", "Die"};
        int AliveCount = 0; int DieCount = 0;

        foreach(string count in enemies)
        {
            if(count == "Alive")
            {
                AliveCount++;
            }
            else
            {
                DieCount++;
            }
        }
        Console.WriteLine("Alive Count is " + AliveCount);
        Console.WriteLine("Die Count is " + DieCount);
    }
}