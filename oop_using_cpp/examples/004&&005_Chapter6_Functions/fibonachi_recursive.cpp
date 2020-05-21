#include<iostream>
using namespace std;

int Fib(int);

int main()
{
    cout << "Enter a number " << endl;
    int number;
    cin >> number;
    int f = Fib(number);
    cout << "Fib(" << number << ") = " << f << endl;
    return 0;
}

int Fib(int x)
{
    if (x == 1 || x == 2)
        return 1;
    return Fib(x - 1) + Fib(x - 2);
}

// Fib(n) = Fib(n-1) + Fib(n-2)
// Fib(1) = 1
// Fib(2) = 1
// 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89