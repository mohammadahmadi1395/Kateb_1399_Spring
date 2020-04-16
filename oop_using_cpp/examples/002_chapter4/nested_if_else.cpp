#include <iostream>
using namespace std;

int main()
{
    int number;
    char grade;
    cout << "enter your number" << endl;
    cin >> number;

    if (number >= 90)
        grade = 'A';
    else if (number >= 80)
        grade = 'B';
    else if (number >= 70)
        grade = 'C';
    else if (number >= 55)
        grade = 'D';
    else
        grade = 'F';

    cout << "grade is " << grade << endl;

    return 0;
}