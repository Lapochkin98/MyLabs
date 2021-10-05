    #include <iostream>
using namespace std;
int main() {
    setlocale(LC_ALL,"rus");
    int MAX = 30;
    char s1[MAX],s2[MAX];
    cout << "Введите значение для первой строки: ";
    cin.get(s1,MAX);
    s2[MAX] = 0;
    s1[MAX] = 0;
    for(int i = 0; i < MAX; i++) {
    s2[i] = s1[i]; }
    cout << "Строка номер 1: ";
    cout << s1 << endl;
    cout << "Строка номер 2: ";
    cout << s2 << endl;
    system("pause");
    return 0; }