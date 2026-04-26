//Q1. Create a Battle System (Functions)
/*
Write a C++ program that simulates a simple turn-based battle between a Hero and a Dragon.

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


#include <iostream>
using namespace std;

  void ShowStats(string name, int health)
  {
    cout<<"Player:"<<name<<endl<<"HP:"<<health;
  }
  
  int TakeDamge(int health, int damge)
  {
    int HP = health - damge;
    if(HP<0)
    HP=0;
    return HP;
  }
  
  bool IsAlive(int health)
  {
    if(health>0)
      return true;
    else
      return false;
  }
  
  void Attack(string name, string defender, int damge)
  {
    cout<<name <<" "<< "Attack"<<" "<<defender<<" "<<"for"<<" "<<damge<<" " <<"Damge!"<<" "<<endl;
  }
  
  int main()
  {
    string player ="Hero";
    string enemy = "Dragon";
    
    int playerHp= 100;
    int enemyHp= 80;
    
    ShowStats(player,playerHp);
    ShowStats(enemy,enemyHp);
    
   cout<<endl<<"_____ROUND 1______" << endl;
    Attack(player,enemy,30);
    enemyHp = TakeDamge(enemyHp,30);
    cout<<"Enemy HP:"<<enemyHp<<endl;
    
    Attack(enemy,player,40);
    playerHp = TakeDamge(playerHp,40);
    cout<<"Player HP:"<<playerHp << endl;
    
   cout<<"_____ROUND 2______"<<endl;
    Attack(player,enemy,50);
    enemyHp = TakeDamge(enemyHp,50);
    cout<<"Dragon HP:"<< enemyHp<<endl;
    
    Attack(enemy,player,20);
    playerHp = TakeDamge(playerHp,20);
    cout<<"Player HP:" << playerHp<<endl;
    
   cout<<"______RESULT______"<<endl;
    if(IsAlive(enemyHp))
      cout << enemy<<" " << "is Still Alive"<<endl;
    else
      cout<<enemy <<" " << "has been Defeat"<<endl;
    
    if(IsAlive(playerHp))
      cout <<player<<" " << "is Still Alive"<<endl;
    else
      cout<<player<<" " << "has been Defeat"<<endl; 
  }
  
  
