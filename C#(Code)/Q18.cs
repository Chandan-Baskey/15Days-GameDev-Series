using System;

class Player
{
    protected string playerName = "Hero";
    
    public void Info()
    {
        System.Console.WriteLine("Player Name:" + this.playerName);
    }
   
}

class Program : Player
{
    static void Main()
    {
        Program p1 = new Program();
    }

}