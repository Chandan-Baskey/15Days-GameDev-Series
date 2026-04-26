using System;
class Program
{
    static int TakeDamge(int health, int damge)
    {
        int Hp = health - damge;
        return Hp;
    }
    static void Main()
    {
        int PlayerHealth = 100;
        PlayerHealth = TakeDamge(PlayerHealth, 34);
        Console.WriteLine("Player Hp " + PlayerHealth);

        int EnemyHealth = 50;
        EnemyHealth = TakeDamge(EnemyHealth, 20);
        Console.WriteLine("Enemy HP " + EnemyHealth);
    }
}