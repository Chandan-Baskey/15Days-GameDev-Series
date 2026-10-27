
using System;

class Info
{
    int id;

    public void SetId(int id)
    {
        if(id>0)
        {
            this.id = id;
        }
        else
        {
            System.Console.WriteLine("Invalid id");
        }
    }

    public void GetId()
    {
         if(id>0)
        {
            System.Console.WriteLine("ID:"+ this.id);
    
        }
        else
        {
          
        }
        
    }
}

class Program 
{
    static void Main()
    {
       Info p1 = new Info();
       p1.SetId(121);
       p1.GetId();

    }

}