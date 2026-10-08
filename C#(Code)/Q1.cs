using System;

class Q1
{
    static void Main()
    {
        const int chestGold = 500;
        int gold = chestGold;

        gold -= 180; //for on apotion -->320
        gold -= 250; // for sword -->70

        bool canAffordSpellBook = gold >= 100;
        Console.WriteLine(canAffordSpellBook ? "Can buy SpellBook"
        : "Cannot buy SpellBook");
    }
}