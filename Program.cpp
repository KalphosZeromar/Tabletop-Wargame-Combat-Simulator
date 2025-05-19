#include <iostream>
#include "mathcore.h"
using namespace std;
int main()
{
    int n, x=1, y=1;
    cout << "Please enter an integer between 1-4";
    cin >> n;
    switch (n)
    {
        case 1://shoot
            cout << shoot(2/3,2/3);
            break;
        case 2://rrh
            cout << shootrrh(2/3,2/3);
            break;
        case 3://rrw
            cout <<  shootrrw(2/3,2/3);
            break;
        case 4://rrb
            cout << shootrrb(2/3,2/3);
            break;
        default:
            break;
    }
    return 0;
}