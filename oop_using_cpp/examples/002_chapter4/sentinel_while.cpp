#include<iostream>
#include<iomanip>
using namespace std;

int main()
{
    int grade, total = 0, counter = 0;
    double average;

    cout << "enter grade (-1 for quit)" << endl;
    cin >> grade;

    while(grade != -1)
    {
        total = total + grade; // total += grade;
        counter++;
        cout << "enter grade" << endl;
        cin >> grade;
    }
    average = static_cast<double>(total) / counter;
    cout << "total is " << total << endl << "average for " << counter << " students is " << fixed << setw(10) << setprecision(2) << average;
    return 0;
}

2 * 3 * 4

++ ++x
x++ 

cout << x << y << z; 