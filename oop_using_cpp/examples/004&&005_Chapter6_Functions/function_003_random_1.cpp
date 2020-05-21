#include<iostream>
#include<cstdlib>
#include<ctime>

using namespace std;

int main()
{
    int seed;
    // cout <<  "enter seed" << endl;
    // cin >> seed;
    seed = time(0);
    srand(seed);

    int x = rand();
    cout << x << endl;
    return 0;
}