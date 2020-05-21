#include<iostream>
#include<ctime>
#include<cmath>

using namespace std;

// output_type function_name(parameter_list);
int power(int, int); // prototype signature
void print4LinesStar();
void printNLinesPlus(int x);
int random();

int main()
{
    int p = 3;
    int q = 4;
    cout << power(p, q) << endl; // call
    // cout << pow(5, 7) << endl;
    printNLinesPlus(2);
    print4LinesStar();
    printNLinesPlus(3);
    time_t  timev;
    cout << time(&timev) << endl;    
    return 0;
}

int power(int x, int y) // definition
{
    int result = 1;
    for (int i = 0; i < y; i++)
        result = result * x;    
    return result;
}

void printNLinesPlus(int x)
{
    for(int i = 0; i < x; i++)
        cout << "+++++++++++++++++++++++++++++" << endl;
}

void print4LinesStar()
{
    cout << "*******************************" << endl;
    cout << "*******************************" << endl;
    cout << "*******************************" << endl;
    cout << "*******************************" << endl;
}

// میتواند ورودی داشته باشد و خروجی هم داشته باشد
// میتواند ورودی نداشته باشد ولی خروجی داشته باشد
// میتواند ورودی داشته باشد و خروجی نداشته باشد
// میتواند ورودی نداشته باشد و خروجی هم نداشته باشد