using System;
class program
{
    public virtual void Show()
    {
        System.Console.WriteLine("This is program");
    }
}

class child : program
{
    public override void Show()
    {
        System.Console.WriteLine("program");
        
        
    }
}

class final
{
    static void Main()
    {
        program p1 = new child();
        p1.Show();
    }
}