using System;

class LargNum
{
    static void Main()
    {
        int[] num = {10,25,5,40,15};
        
        int largNu = num[0];
        int smallNu = num[0];

        int total = 0;

        int eNum = 0;
        int oNum = 0;

        int lNum = int.MinValue;
        int sNum = int.MinValue;

        for(int i=1; i<num.Length; i++)
        {
            if(num[i]>largNu)
            {
                largNu = num[i];
              
            }

            if(num[i]<smallNu)
            {
                smallNu = num[i];

            }  
        }

        for(int i=0; i<num.Length;i++)
        {
            total+=num[i];
        }

        for(int i=0; i<num.Length;i++)
        {
            if(num[i]%2==0)
            {
                eNum++;
            }
            else
            {
                oNum++;
            }
        }

       for(int j=0; j<num.Length;j++)
        {
            if(num[j]>lNum)
            {
                sNum = lNum;
                lNum = num[j];
            }
             else if(num[j]>sNum && num[j] != lNum)
            {
                sNum = num[j];
            }
        }
        System.Console.WriteLine("Largest Num: "+largNu);
        System.Console.WriteLine("------------------------");
        System.Console.WriteLine("Smallest Num: "+smallNu);
        System.Console.WriteLine("------------------------");
        System.Console.WriteLine("Total Sum: "+total);
        System.Console.WriteLine("------------------------");
        Console.WriteLine("Total EvenNum: "+eNum);
        System.Console.WriteLine("Total OddNum: "+oNum);
        System.Console.WriteLine("------------------------");
        System.Console.WriteLine("Largest Num: "+lNum);
        System.Console.WriteLine("ScondL Num: "+sNum);
    }
}