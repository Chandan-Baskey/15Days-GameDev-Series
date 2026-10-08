using System;
class Q2
{
    static void Main()
    {
        System.Console.WriteLine("Enter your RarityLoot Number (0-150):");
        int rarityScore = int.Parse(Console.ReadLine());

        const int itemScore = 150;
        if (rarityScore <= itemScore)
        {
            if (rarityScore >= 90)
            {
                System.Console.WriteLine("Legendary Loot");
            }
            else if (rarityScore >= 70 && rarityScore < 90)
            {
                System.Console.WriteLine("Epic Loot");
            }
            else if (rarityScore >= 50 && rarityScore < 70)
            {
                System.Console.WriteLine("Rare Loot");
            }
            else if (rarityScore >= 30 && rarityScore < 50)
            {
                System.Console.WriteLine("Uncommon Loot");
            }
            else
            {
                System.Console.WriteLine("Common Loot");
            }
        }
        else
        {
            System.Console.WriteLine("Invalid Number");
        }
    }
}