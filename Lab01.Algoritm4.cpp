#include <iostream>
#include <math.h>
#include <stdio.h>
using namespace std;

int main(){
    double p,s,c,a,b;
    cout <<"Введите периметр равностороннего треугольника:";
    cin >> p;
    c=p/3;
    a=c*c*sqrt(3);
    s=a/4;
    cout<<"Площадь треугольника равна:" <<s <<endl;

 return 0;}
