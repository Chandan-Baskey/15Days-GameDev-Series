using System;
class Game
{
    static void Main()
    {
        Console.WriteLine("Enter Your Num: ");
        int num = int.Parse(Console.ReadLine());

        switch(num)
        {
             case 1:
                Console.WriteLine("Easy");
                break;
             case 2:
                Console.WriteLine("Medium");
                break;
             case 3:
                 Console.WriteLine("Hard");
                 break;
            default:
                Console.WriteLine("Invalid Num");
                break;    
        }                
    } 
}