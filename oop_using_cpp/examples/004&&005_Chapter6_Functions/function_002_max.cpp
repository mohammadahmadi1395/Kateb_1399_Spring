#include<iostream>

using namespace std;

int calculateMax(int, int, int); // prototype

int main()
{
    cout << "Enter 3 numbers" << endl;
    int first, second, third;
    cin >> first >> second >> third;
    int max = calculateMax(first, second, third);
    cout << "maximum number is " << max << endl;
    return 0;
}

int calculateMax(int f, int s, int t)
{
    int max = f;
    if (s > max)
        max = s;
    if (t > max)
        max = t;    
    return max;
}
