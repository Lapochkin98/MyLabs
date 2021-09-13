#include <iostream>
#include <math.h>
using namespace std;

int main(){
    int a,b,c,d;
    cout<<"Введите первое однозначное число:";
    cin>>a;
    cout<<"Введите второе однозначное число:";
    cin>>b;
    cout<<"Введите результат умножения:";
    cin>>c;
    d=a*b;
    if (d==c)
        cout<<"Ответ верный";
    
    else
    {
        cout<<"Ответ неверный."<<"Правильный ответ: " <<d;
    }          
    return 0;
    }