#include <iostream>
using namespace std;

int main()
{
    cout << boolalpha << "true && true => " << (true && true) << endl
         << "true && false => " << (true && false) << endl
         << "false && true => " << (false && true) << endl
         << "false && false => " << (false && false) << endl
         << endl
         << endl
         << "true || true => " << (true || true) << endl
         << "true || false => " << (true || false) << endl
         << "false || true => " << (false || true) << endl
         << "false || false => " << (false || false) << endl
         << endl
         << endl
         << "! true => " << (!true) << endl
         << "! false => " << (!false) << endl;

    return 0;
}