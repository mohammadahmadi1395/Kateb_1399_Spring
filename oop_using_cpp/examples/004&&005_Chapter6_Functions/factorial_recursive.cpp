#include<iostream>
using namespace std;

unsigned long recursiveFactorial(int);

int main()
{
    cout << "Enter a number" << endl;
    int number;
    cin >> number;
    cout << recursiveFactorial(number);
    return 0;
}

unsigned long iteratorFactorial(int x)
{
    unsigned long result = 1;
    // for(int i = x; i > 0; i--)
    //     result *= i;

    for(int i = 1; i <= x; i++)
        result *= i;

    return result;
}

unsigned long recursiveFactorial(int x)
{
    if (x == 1)
        return 1;    
    return x * recursiveFactorial(x - 1);
}

