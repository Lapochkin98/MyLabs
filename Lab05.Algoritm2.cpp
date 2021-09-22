#include <iostream>

using namespace std;

int main(){
    double a,x,y;
    x=5;
    a=10.2;
    do {
        y=a*x*x;
        x++;
        cout << "\n " << y;
    }
    while (x<=35);
    {
        system("pause");
    }
    return 0;
}