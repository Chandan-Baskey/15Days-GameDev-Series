using System;

class Q8
{
    static void Main()
    {
        string[] inventory ={ "Sword", "Potion", "Shield", "Key", "Bow"};

        for(int i=0; i<inventory.Length; i++)
        {
            Console.WriteLine(inventory[i] + " is at index " + i);
        }
        inventory[1] = "Mega Potion";
        Console.WriteLine(inventory[1] + " is at index " + 1);
    }
}