using System;
class LQ4
{
    static void Main()
    {
        string[] loot = { "Gem", "Gold", "Bomb", "Sword", "Poison", "Key" };
        for(int i=0;i<loot.Length; i++)
        {
            if(i%2==0)
            {
               continue;
            }
            System.Console.WriteLine(loot[i]);
        }   
    }  
}