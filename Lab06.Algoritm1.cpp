
#include <iostream>
using namespace std;
 
int main()
{
    setlocale(LC_ALL, "Russian");
 
    const int MASS = 10;
    double arr[MASS];
    int i=0;
    cout << "Введите " << MASS << " чисел:" << endl;
    for ( i=0; i<MASS; i++)
        cin >> arr[i];
 
    int x = -1;
    for (int i=MASS-1; i>=0; i--)
        if (arr[i] < 0)
        {
            x = i;
            break;
        }
 
    if ( x!= -1)
    {
        int sum = 0;
 
        for (int i=x+1; (i<MASS); i++)
            sum = sum + arr[i];
 
        cout << "Сумма равна:  " << sum << endl;
    }
    else
        cout << "В массиве нет отрицательных чисел" << endl;
 
    system("pause");
    return 0;
}