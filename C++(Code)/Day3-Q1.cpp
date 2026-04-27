#include<iostream>
using namespace std;
int TakeDamge(int health, int damge)
    {
        int Hp = health - damge;
        if (Hp <= 0)
            Hp = 0;
        return Hp;
    }

    void IsAlive(int health)
    {
        if (health > 0)
            cout<<"Is Alive"<<endl  ;
        else
            cout<<"Game Over"<<endl;
    }

    int main()
    {
        int playerHealth = 100;
        while (playerHealth > 0)
        {
            cout<<"Enter Your Damge:";
            int damge;
            cin>>damge;
            playerHealth = TakeDamge(playerHealth, damge);
            IsAlive(playerHealth);
        }
        return 0;
    }