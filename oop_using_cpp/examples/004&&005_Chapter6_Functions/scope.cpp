#include<iostream>

using namespace std;
int x = 1; // global
int main()
{
    int x = 2; // local

    {
        int x = 3; // very local
    }

    cout << "global x = " << ::x << endl; // 1
    cout << "local x = " << x << endl; // 2


    return 0;
}