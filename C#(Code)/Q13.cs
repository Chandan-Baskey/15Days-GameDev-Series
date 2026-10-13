using System;

class Info
{
    int PlayerID;
    string playerName;
    int playerLvL;

    public void setInfo(int id, string name, int lvl)
    {
        this.PlayerID=id;
        this.playerName = name;
        this.playerLvL = lvl;
    }
    public void getInfo()
    {
        Console.WriteLine($"PlayerID:-{PlayerID} || PlayerName:-{playerName} || PlayerLevel:-{playerLvL}");
    }

    static void Main()
    {
        System.Console.WriteLine("Enter Your ID:-");
        int id =int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Your Name:-");
        string name = Console.ReadLine();

        System.Console.WriteLine("Enter Your LVL:-");
        int lvl =int.Parse(Console.ReadLine());

        Info P1 = new Info();
        P1.setInfo(id,name,lvl);
        P1.getInfo();


        Info P2 = new Info();
        P2.setInfo(id,name,lvl);
        P2.getInfo();
        
        
    }
}