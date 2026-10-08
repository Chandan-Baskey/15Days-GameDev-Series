using System;

class Q3
{
    static void Main()
    {
        Console.WriteLine("Enter You Num: ");
        string num = Console.ReadLine();
        
        
        if(int.TryParse(num, out int age) )
        {
            Console.WriteLine("Your Age is: " + age);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

    }
}