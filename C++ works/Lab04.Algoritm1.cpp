#include <iostream>
#include <math.h>
using namespace std;

int main(){
    int i;
    double h,f,a,b,x;
    cout << "Введите число А:";
    cin >> a;
    cout <<"Введите число B:";
    cin >> b;
    cout <<"Введите чмсло Н:";
    cin >>h;
    while (a<=b){
       
    f=1/a*sqrt(pow(a,2) + 0.25);
    a+=h;
    cout <<" "<<f;
    }

return 0;
}