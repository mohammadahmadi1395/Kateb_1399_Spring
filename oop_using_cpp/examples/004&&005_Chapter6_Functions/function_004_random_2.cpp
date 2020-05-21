#include<iostream>
#include<iomanip>
#include<cstdlib>
#include<ctime>

using namespace std;

int main()
{
    int seed;
    // cout <<  "enter seed" << endl;
    // cin >> seed;
    seed = time(0);
    srand(seed);

    int f1 = 0, f2 = 0, f3 = 0, f4 = 0, f5 = 0, f6 = 0;
    for(int i = 0; i < 60000000000; i++)
    {
        int x = rand() % 6 + 1; // ===> 1, 2, 3, 4, 5, 6
        // if (x == 1)
        //     f1++;
        // else if (x == 2)
        //     f2++;
        // else if (x == 3)
        //     f3++;
        // else if (x == 4)
        //     f4++;
        // else if (x == 5)
        //     f5++;
        // else if (x == 6)
        //     f6++;        
        switch(x)
        {
            case 1:
                f1++;
                break;
            case 2:
                f2++;
                break;
            case 3:
                f3++;
                break;
            case 4:
                f4++;
                break;
            case 5:
                f5++;
                break;
            case 6:
                f6++;
                break;
            default:
                break;
        }
    }

    cout << setw(7) << "Face" << setw(12) << "Frequency" << endl;
    cout << setw(7) <<"1" << setw(12) << f1 << endl;
    cout << setw(7) <<"2" << setw(12) << f2 << endl;
    cout << setw(7) <<"3" << setw(12) << f3 << endl;
    cout << setw(7) <<"4" << setw(12) << f4 << endl;
    cout << setw(7) <<"5" << setw(12) << f5 << endl;
    cout << setw(7) <<"6" << setw(12) << f6 << endl;

    return 0;
}