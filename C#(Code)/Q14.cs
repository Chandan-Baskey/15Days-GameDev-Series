using System;

class Program
{
    static void Main()
    {
        int[] number = {2,3,6,7,11,15};
        int i =0;
        int j = number.Length-1;
        int target = 9;
        while(i<j)
        {
           int sum = number[i]+number[j];

           if(sum==target)
            {
                System.Console.WriteLine();
                break;
            }
            else if(sum<target)
            {
                i++;
            }
            else if(sum>target)
            {
                j--;
            }
             else
            {
                System.Console.WriteLine("Invaild");
            }
        }
    }
}