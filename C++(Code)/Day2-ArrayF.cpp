#include <iostream>
using namespace std;
int main()
{
    string enemies[4] = { "Goblin","Skeleton","Troll","Dragon" };
    cout << "" << endl;
    cout << enemies[0] << endl;
    cout << enemies[1] << endl;
    cout << enemies[2] << endl;
    cout << enemies[3] << endl;
    
    int size = sizeof(enemies)/sizeof(enemies[0]);
    cout<<"Array Size: "<<size<<endl;
    for (int i=0; i< size; i++)  // for loop
    {
        cout<< i<<endl;
        cout<<enemies[i]<<endl;
    }
    

}