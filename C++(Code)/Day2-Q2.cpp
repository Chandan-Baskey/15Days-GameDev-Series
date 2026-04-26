#include <iostream>

using namespace std;

void Shoot(int damge, int enemy[], int size)
{
  for(int i=0; i<size;i++)
  {
    enemy[i]-=damge;
    cout<<"Enemy: "<<  (i + 1) << "Health: " << enemy[i]<<endl;
  }
}
int main()
{
  int enemy[]={20,50,10};
  int damge;
  cout<<"Enter Your Damge"<<endl;
  cin>>damge;
  int size = sizeof(enemy)/sizeof(enemy[0]);
  Shoot(damge,enemy,size);
}