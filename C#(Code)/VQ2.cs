using System;

class VQ2
{
    static void Main()
    {
        System.Console.WriteLine("See Your Weapon Damage[Sword,Bow,Staff,basic]");
        System.Console.WriteLine("Enter Your Weapon NUMBER[1,2,3,4]");
        int UserInput;
        UserInput = int.Parse(Console.ReadLine());

        switch(UserInput)
        {
            case 1:
                System.Console.WriteLine("40");
                break;
            case 2:
                System.Console.WriteLine("25");
                break;
            case 3:
                System.Console.WriteLine("60");
                break;
            case 4:
                System.Console.WriteLine("10");
                break;
            default:
                System.Console.WriteLine("0");
                break;        
        }
    }
}