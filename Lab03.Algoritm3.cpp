#include <iostream>
#include <math.h>
#include <iomanip>
using namespace std;

int main() 
{
    int a,b,c,d,i;
    c= 0 ;
    cout << "Введите число A: ";
    cin >> a ;
    cout << "Введите число B: ";
    cin >>b;
    for (d=a; d < b+1; d++)         {
            for(i=0; i<d; i++)      {
            cout<< setw(3) << d;              } // Тут setw(2) можно меньше, но так считать легче
            cout << "|";
                                    }
    system("pause"); 
return 0;

}