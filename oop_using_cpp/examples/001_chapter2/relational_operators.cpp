#include<iostream>
using namespace  std;

int main()
{
    int num1, num2;

    cout << "enter 2 numbers" << endl;
    cin >> num1 >> num2;

    // == != > < >= <=
    if (num1 == num2)
        cout << num1 << " is equal to " << num2 << endl;
    
    if (num1 != num2)
        cout << num1 << " is not equal to " << num2 << endl;

    if (num1 > num2)
        cout << num1 <<  " is greather than " << num2 << endl;

    if (num1 < num2)
        cout << num1 << " is less than " << num2 << endl;

    if (num1 >= num2)
        cout << num1 << " is equal to or greather than " << num2 << endl;
    
    if (num1 <= num2)
        cout << num1 << " is equal to or less than " << num2 << endl;
    
    return 0;
}