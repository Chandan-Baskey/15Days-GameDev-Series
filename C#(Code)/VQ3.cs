using System;

class VQ3
{
    static void Main()
    {
        System.Console.WriteLine("You have key then press 1 and if you don't have key then press 0");
        bool isAlive = int.Parse(Console.ReadLine())==1?true:false;

        System.Console.WriteLine("Enter your LVL");
        int playerLVL = int.Parse(Console.ReadLine());

        System.Console.WriteLine("You have Master key then press 1 and if you don't have Master key then press 0");
        bool hasMasterKey = int.Parse(Console.ReadLine())==1?true:false;

        if(isAlive && playerLVL>=5 || hasMasterKey)
        {
            System.Console.WriteLine("You can open the door");
        }
        else
        {
            System.Console.WriteLine("You can't open the door");
        }
    }
}