#include<iostream>
#include<iomanip>
using namespace std;

int main()
{
    int grade, total = 0, counter = 1;
    double average;

    while(counter <= 7)
    {
        cout << "enter grade" << endl;
        cin >> grade;
        total = total + grade; // total += grade;
        counter++;
    }
    average = static_cast<double>(total) / 7;
    cout << "total is " << total << endl << "average is " << fixed << setw(10) << setprecision(2) << average;
    return 0;
}


