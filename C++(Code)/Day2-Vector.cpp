#include <iostream>
#include <vector>
#include <algorithm> // for find
using namespace std;

int main()
{
    vector<int> inventory;

    inventory.push_back(103);
    inventory.push_back(104);
    inventory.push_back(106);

    cout << inventory[0] << endl;
    cout << inventory[1] << endl;
    cout << inventory[2] << endl;

    cout << "Count: " << inventory.size() << endl; // Count means how many data   
    inventory.pop_back();
    cout<< "Remove: "<< "Count: " << inventory.size() << endl;          

}