using System;

class Q5
{
    static void Main()
    {
        System.Console.WriteLine("Enter Your Weapon ID:");
        int weaponID = int.Parse(Console.ReadLine());

        switch(weaponID)
        {
            case 1:
                {
                    Console.WriteLine("You have selected Sword");
                    break;
                }
            case 2:
                {
                    Console.WriteLine("You have selected Bow");
                    break;
                }
            case 3:
                {
                    Console.WriteLine("You have selected Spear");
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid Weapon ID");
                    break;
                }        
        }
    }
}