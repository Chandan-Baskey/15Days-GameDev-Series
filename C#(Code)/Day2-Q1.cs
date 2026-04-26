//Q1. Create a Battle System (Functions)
/*
Write a C# program that simulates a simple turn-based battle between a Hero and a Dragon.

The program must include the following functions:

ShowStats(): Displays the Name and HP (Health Points) of the character.
TakeDamage(): Reduces health by the damage amount and returns the new HP.
IsAlive(): Checks if HP is greater than 0 and returns true or false.
Attack(): Prints a message showing who is attacking whom and the damage dealt.
In the Main function, simulate a 2-round battle using these functions.

Sample Output:
Hero HP: 100
Dragon HP: 80
_____ROUND 1______
Hero Attack Dragon for 30 Damge!
Dragon HP: 50
Dragon Attack Hero for 40 Damge!
Player HP: 60
_____ROUND 2______
Hero Attack Dragon for 50 Damge!
Dragon HP: 0
Dragon Attack Hero for 20 Damge!
Player HP: 40
______RESULT______
Dragon is Still Alive
Player has been Defeat

*/

using System;
class Program
{
  static void ShowStats(string name, int health)
  {
    Console.WriteLine("Player: " + name);
    Console.WriteLine("HP:" + health);
  }

  static int TakeDamge(int health, int damge)
  {
    int Hp = health - damge;
    if (Hp < 0)
      Hp = 0;
    return Hp;
  }

  static bool IsAlive(int health)
  {
    if (health > 0)
      return true;
    else
      return false;
  }

  static void Attack(string attack, string defender, int damge)
  {
    Console.WriteLine(attack + " Attack " + defender + " for " + damge + " Damge!");
  }

  static void Main()
  {
    string player = "Hero";
    string enemy = "Dragon";

    int playerHp = 100;
    int enemyHp = 80;

    ShowStats(player, playerHp);
    ShowStats(enemy, enemyHp);

    Console.WriteLine("_____ROUND 1______");
    Attack(player, enemy, 30);
    enemyHp = TakeDamge(enemyHp, 30);
    Console.WriteLine("Dragon HP:" + enemyHp);

    Attack(enemy, player, 40);
    playerHp = TakeDamge(playerHp, 40);
    Console.WriteLine("Player HP:" + playerHp);

    Console.WriteLine("_____ROUND 2______");
    Attack(player, enemy, 50);
    enemyHp = TakeDamge(enemyHp, 50);
    Console.WriteLine("Dragon HP:" + enemyHp);

    Attack(enemy, player, 20);
    playerHp = TakeDamge(playerHp, 20);
    Console.WriteLine("Player HP:" + playerHp);

    Console.WriteLine("______RESULT______");
    if (IsAlive(enemyHp))
      Console.WriteLine(enemy + "is Still Alive");
    else
      Console.WriteLine(enemy + "has been Defeat");

    if (IsAlive(playerHp))
      Console.WriteLine(player + "is Still Alive");
    else
      Console.WriteLine(player + "has been Defeat");

  }
}