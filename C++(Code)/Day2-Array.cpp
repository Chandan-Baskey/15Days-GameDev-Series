#include <iostream>
using namespace std;
int main()
{
    int enemies[3] = { 10, 20, 30 };
    cout << enemies[0] << endl;
    cout << enemies[1] << endl;
    cout << enemies[2] << endl;

    int size = sizeof(enemies) / sizeof(enemies[0]);
    cout << size << endl;

    for (int i = 0; i < size; i++) // for loop
    {
        cout << i << " Index" << endl;
        cout << "Value " << enemies[i] << endl;
    }
    enemies[0] = 50;
    cout << "" << endl;
    cout << "replace Index 0 Value: " << enemies[0] << endl; // replace Index Value
}