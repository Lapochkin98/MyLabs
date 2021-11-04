#include <iostream>
#include <math.h>

using namespace std;
void form(int x)
{
    double z=2*x+4 * pow(x,1/2) - 5;
}
int main()
{
    double y,  &z = y;
    int x;
    cout << "Введите значение x: " << endl;
    cin >> x;
    cout << "Ваш ответ: " << endl;
    cout << y;
}