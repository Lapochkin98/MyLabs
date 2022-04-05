#include <iostream>
#include <math.h>
using namespace std;

int main()
{
    int a,b,c,d;
    c= 0 ;
    cout << "Введите число A: ";
    cin >> a ;
    cout << "Введите число B: ";
    cin >>b;
    for (d=a; d<=b; d++)
        cout <<d<<" "; 
    cout <<"Всего чисел: "<< ((c+1)+(b-a)) <<endl;
    system("pause");
return 0; 
}