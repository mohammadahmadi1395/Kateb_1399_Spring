#include <iostream>
using namespace std;

int main()
{
    int number1, number2;

    cout << "please enter two numbers" << endl; //prompt
    cin >> number1 >> number2;

    int sum = number1 + number2;

    cout << number1 << " + " << number2  << " = " << sum << endl;

    return 0;
}