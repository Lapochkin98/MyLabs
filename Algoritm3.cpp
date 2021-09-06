#include <iostream>
#include <stdio.h>
#include <math.h>
using namespace std;

int main(){
    double x, y, z, a, b, c;
    cout <<"Введите x:";
    cin >> x;
    cout <<"Введите y:";
    cin >> y;
    cout <<"Введите z:";
    cin >> z;
    b=2*tan(x);
    c=1-2*cos(3*y)+tan(z);
    a=b/c;
    cout<<"Полученный ответ:" <<a <<endl;

 return 0;}