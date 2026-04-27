
/*
Q1: Player Health System
👉 Input:
Player health = 100
Enemy damage (user input)
👉 Task:
Reduce health
Print:
"Alive" if health > 0
"Game Over" if health ≤ 0
*/

using System;
class Plyer
{
    static int TakeDamge(int health, int damge)
    {
        int Hp = health - damge;
        if (Hp <= 0)
            Hp = 0;
        return Hp;
    }

    static void IsAlive(int health)
    {
        if (health > 0)
            Console.WriteLine("Is Alive");
        else
            Console.WriteLine("Game Over");
    }

    static void Main()
    {
        int playerHealth = 100;
        while (playerHealth > 0)
        {
            Console.WriteLine("Enter Your Damge:");
            int damge = int.Parse(Console.ReadLine());
            playerHealth = TakeDamge(playerHealth, damge);
            IsAlive(playerHealth);
        }
    }
}