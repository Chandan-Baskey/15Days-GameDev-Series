#include<iostream>
#include<vector>
using namespace std;

int main()
{
    int enemy[] = {100, 23, 0, 45, 70, 0, 35};
    vector<int> health;

    int size = sizeof(enemy) / sizeof(enemy[0]);

    for (int i = 0; i < size; i++)
    {
        if (enemy[i] != 0)
        {
            health.push_back(enemy[i]);
        }
    }

    for (int i = 0; i < health.size(); i++)
    {
        cout << health[i] << endl;
    }

    return 0;
}