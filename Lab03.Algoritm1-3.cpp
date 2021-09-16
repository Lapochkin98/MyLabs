#include <iostream>
#include <math.h>
using namespace std;

int main()
{
    int a, b;
    cout << "Введите B = "; 
    cin >> b;
    cout << "Введите A = "; 
    cin >> a;
    for (int i = b-1; i > a; i--)
        cout << i << " ";
    cout << endl << "Количество цифр: " << b - a - 1;
return 0;
}