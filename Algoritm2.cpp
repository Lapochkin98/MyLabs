#include <iostream>
using namespace std;

int main(){
    setlocale(LC_ALL, "rus");
    int num1;
    cout <<"Введите четырехзначное число: ";
    cin>> num1;
    cout << "Цифры в обратном порядке: ";
    cout << num1 % 10;
    num1 /= 10; 
    cout << num1 % 10; 
    num1 /= 10;
    cout << num1 % 10;
    num1 /= 10;
    cout << num1 % 10;
    num1 /= 10;
    cout << endl;
return 0; }