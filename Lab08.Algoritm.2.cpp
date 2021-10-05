#include <iostream>
#include <string>
#include <cstring>
using namespace std;
int main() {
    string str;
    string symb = "*"; 
    cout << "Введите символ: " << endl;
    cin >> str; 
    str.replace (0, 256, symb);
    cout << "Результат заменённый на '*': " << str << endl;

    char str2;
    cout << "Введите символ: " << endl;
    cin >> str2;
    str2 = '*';
    cout << str2 << endl;

return 0; }