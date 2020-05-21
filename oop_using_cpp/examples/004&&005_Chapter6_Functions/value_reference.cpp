#include<iostream>
using namespace std;

int squareByValue(int);
int squareByReference(int &);

int main()
{
    int x = 2;
    cout << "x before calling functions = " << x << endl; // 2
    int s = squareByValue(x);
    cout << "square of x is " << s << endl; // 4
    cout << "x after calling function (by value) = " << x << endl; // 2

    int z = 4;
    cout << "z befor calling function = " << z << endl; // 4
    int t =  squareByValue(z);
    cout << "square of z is " << t << endl; // 16
    cout << "z after calling function (by reference) = " << z << endl; // 16

    return 0;
}

int squareByValue(int x)
{
    x = x * x;
    return x;
}
int squareByReference(int & x)
{
    x = x * x;
    return x;
}