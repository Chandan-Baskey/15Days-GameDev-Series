using System;


public class Player
{
    public int health;

    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            if(value<0) value = 0;
            health = value;
        }
    }
}
class DAY2
{
    static void Main()
    {
        Player player = new Player();
        player.Health = 100;
        Console.WriteLine(player.Health);
        player.Health -= 200;
        Console.WriteLine(player.Health);
    }
}