//Static And Instance Members of a Class In C#

using System;
using System.ComponentModel.Design.Serialization;
using System.Net.NetworkInformation;

class Info
{
    public String PlayerName;
    public int score;
    public static int hp;
    

public static void HP()
    {
        hp=100;
        Console.WriteLine("Hp Value is Constant");
    }
    public void PlayerInfo() 
    {
        string playerInfo ="Player Name:"+ this.PlayerName+" HP: "+ hp + " Score:"+this.score;
        Console.WriteLine(playerInfo);
    }
    
}

class Details
{
    static void Main()
    {
        Info p1 = new Info();
        p1.PlayerName ="Alex";
        p1.score =50;
        p1.PlayerInfo();
        Info.HP();

        Info p2 = new Info();
        p2.PlayerName ="Max";
        
        p2.score =40;
        p2.PlayerInfo();

    }
}