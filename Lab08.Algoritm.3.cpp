#include <iostream>
#include <string>
using namespace std;
int main() {
    setlocale (LC_ALL, "rus");
    int n1, n2;
    string s1, s2, result;
    cout << "Введите n1: " << endl;
    cin >> n1;
    cout << "Введите n2: " << endl;
    cin >> n2;
    cin.ignore();
    cout << "Введите строку s1: " << endl;
    getline(cin, s1);
    cout << s1;
    cout << "Введите строку s2: " << endl;
    getline(cin, s2);
    result = s1.substr(0, n1) + s2.substr(s2.size() - n2);
    cout << result << endl;
    return 0; }