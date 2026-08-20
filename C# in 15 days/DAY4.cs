using System;
using System.Collections;

class DAY4
{
    static void Main()
    {
        int wwapon = 2;

        switch(wwapon)
        {
            case 1:
                 Console.WriteLine("Sword");
                 break;
            
            case 2:
                 Console.WriteLine("Box");
                 break;
            case 3:
                Console.WriteLine("Gun");
                break;

            default:
                  Console.WriteLine("Empty ");
                  break;         
        }
    }

    

}    