using System;

public class Player
{
    int health =100;

    public int _Health
    {
        get{return this.health;}
        private set {health= value;}
    }
    public void TakeDamge(int dam)
    {
        _Health -= dam;
        System.Console.WriteLine("Player Health: "+ _Health);
    }
    
}
class Program
{
    static void Main()
    {
        Player p1 = new Player();
        p1.TakeDamge(39);
        System.Console.WriteLine(p1._Health);
    }
}