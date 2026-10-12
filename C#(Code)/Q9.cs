using System;

class Q8
{
    static void Main(string[] args)
    {
        int[] enemyHP = {  0, 120, 0, 0, 200,0 };
        int AliveCount = 0;
        int DeadCount = 0;

        for (int i=0;i<enemyHP.Length;i++)
        {
            if(enemyHP[i]==0)
            {
                DeadCount++;
            }
            else
            {
                AliveCount++;
            }
        }
        Console.WriteLine("Alive enemies: " + AliveCount);
        Console.WriteLine("Dead enemies: " + DeadCount);
    }
}