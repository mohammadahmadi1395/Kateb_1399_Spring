#include <iostream>
#include <cmath>
#include<iomanip>
using namespace std;

// double power(double base, int p);

int main()
{
    // a = p (1 + r) ^ n
    // p => original amount
    // r => anual interest rate
    // n => number of years
    // a => amount of deposit at the end of nth year
    double p, r;
    int n;
    cout << "Enter p, r, n" << endl;
    cin >> p >> r >> n;

    if (r > 1)
        r = r * 0.01;

    for (int i = 1; i <= n; i++)
    {
        double result = p * pow(1 + r, i);
        cout << "your amount of deposit is : " << fixed << setw(20) << setprecision(2) << result << endl;
    }

    return 0;
}

// double power(double base, int p)
// {
//     double result = 1;
//     for(int i = 1; i <= p; i++)
//         result = result * base; // result *= base;
//     return result;
// }