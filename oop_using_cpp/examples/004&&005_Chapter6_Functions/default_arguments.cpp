#include<iostream>

using namespace std;

// int calculate(int);
// int calculate(int, int);
// int calculate(int, int, int);

int calculate(int, int = 1, int = 1);

int main()
{
    int x = 2;
    int y = 3;
    int z = 4;
    cout << "1 dimensional shape => length = " << calculate(x) << endl;
    cout << "2 dimensional shape => area = " << calculate(x, y) << endl;
    cout << "3 dimensional shape => volume = " << calculate(x, y, z) << endl;
    return 0;
}


// int calculate(int x) // length
// {
//     return x;
// }

// int calculate(int x, int y) // area
// {
//     return x * y;
// }

// int calculate(int x, int y, int z) // volume
// {
//     return x * y * z;
// }

int calculate(int x, int y, int z)
{
    return x * y * z;
}


