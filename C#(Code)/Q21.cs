class GameInfo
{
    public string name = string.Empty;
    public int hp = 0;
    public int Damage = 0;

    public void InfoId()
    {
        System.Console.WriteLine("Game Info");
    }
}

class Player : GameInfo
{
    public int pID = 0;
    public int pLvL = 0;
}

class Enemy : Player
{
    public int eId = 0;
    public int eLvL = 0;
}

class Scene
{
    static void Main()
    {
        Player p1 = new Player();
        p1.name = "Alex";
        p1.InfoId();


        Enemy e1 = new Enemy();
        

        System.Console.WriteLine(p1.name);
        System.Console.WriteLine(e1.name);
    }
}