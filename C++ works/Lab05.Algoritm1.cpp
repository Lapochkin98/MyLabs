#include <iostream>
using namespace std;

int main(){
    int x,i;
    x=100;
    while (i>x){
        cout << "Введите число больше 100:";
        cin >> i;
        if (i>x){
            break;
        }
    }
return 0;
}