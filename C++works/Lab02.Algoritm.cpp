#include <iostream>
#include <math.h>
using namespace std;

int main(){
    int a,b;
    cout<<"Введите a:";
    cin>>a;
    cout<<"Введите b:";
    cin>>b;
    if (a!=b){
        a=a+b;
        b=a+b;
        cout<<"a="<<a;
        cout<<"b=\n"<<b;
             }
    else { 
        a=0;
        b=0;
        cout<<"a= "<<a;
        cout<<"b= "<<b;
         }   
    return 0;
          }