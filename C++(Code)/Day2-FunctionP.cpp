#include <iostream>
using namespace std;

void Shoot(string name, int hp)
{
  cout<<"PLAYER NAME: "<<name << endl << "HP:"<<hp;
}
int main() 
{
  Shoot("UNIQUE",100);
  return 0;
}