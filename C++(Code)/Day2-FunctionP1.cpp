#include <iostream>
using namespace std;

int TakeDamge(int health, int damge)
{
  int Hp = health - damge;
  return Hp;
}

int main()
{
  int PlayerHealth = 100;
  PlayerHealth = TakeDamge(PlayerHealth, 34);
  cout<<"Player Hp " << PlayerHealth << endl;

  int EnemyHealth = 50;
  EnemyHealth = TakeDamge(EnemyHealth, 20);
  cout<<"Player Hp " << EnemyHealth;
}
