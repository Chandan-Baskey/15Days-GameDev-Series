using System;
class DAY1
{
    static void Main()
    {
        int day = 3;
        // switch (day)
        // {
        //     case 1:
        //         Console.WriteLine("Mon");
        //         break;
            
        //     case 2:
        //         Console.WriteLine("Tues");
        //         break;
            
        //     case 3:
        //         Console.WriteLine("Wed");
        //         break;


        //     default:
        //         Console.WriteLine("Unk day");
        //         break;        
        // }

        string dayName = day switch
        {
            1 => "Mon",
            2 => "Tues",
            3 => "Wed",
            _ => "Unk day"
        };
        Console.WriteLine(dayName);
    }

}