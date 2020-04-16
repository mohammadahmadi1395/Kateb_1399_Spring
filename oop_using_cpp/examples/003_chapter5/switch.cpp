#include <iostream>
using namespace std;

int main()
{
    char grade;
    int count = 10;
    int counter = 1;
    int aCounter = 0, bCounter = 0, cCounter = 0, dCounter = 0, fCounter = 0;

    cout << "enter grades (EOF for quit)" << endl;
    while ((grade = cin.get()) != EOF)
    {
        // cin >> grade;
        switch (grade)
        {
            case 'A':
            case 'a':
                aCounter++;
                break;
            case 'B': 
            case 'b': 
                bCounter++;
                break;
            case 'C':
            case 'c':
                cCounter++;
                break;
            case 'D':
            case 'd':
                dCounter++;
                break;
            case 'F':
            case 'f':
                fCounter++;
                break;
            case '\n':
            case '\t':
            case ' ':
                break;
            default:
                cout << "Incorrect input" << endl;
        }
        counter++;
    }
    cout << "A : " << aCounter << endl
         << "B : " << bCounter << endl
         << "C : " << cCounter << endl
         << "D : " << dCounter << endl
         << "F : " << fCounter << endl;
    return 0;
}

// while (counter <= 10)
// {
//     cin >> grade;
//     if (grade == 'A')
//         aCounter++;
//     else if (grade == 'B')
//         bCounter++;
//     else if (grade == 'C')
//         cCounter++;
//     else if (grade == 'D')
//         dCounter++;
//     else if (grade == 'F')
//         fCounter++;
//     else if (grade == '\n' || grade == '\t' || grade == ' ')
//     {}
//     else
//         cout << "Incorrect input" << endl;
//     counter++;
// }




break کنترل اجرای برنامه را به انتهای حلقه منتقل می کند
continue کنترل اجرای برنامه را به انتهای تکرار جاری منتقل میکند

for (int i = 1; i <= 10; i++)
{
    if (i % 3 == 0)
        // break;
        continue;
    cout << i * i;

}
// break ====> 1 4
// continue =======> 1 4 16 25 49 64 100 
