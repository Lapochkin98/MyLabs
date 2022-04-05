#include <iostream>
using namespace std;
void lol(int a, int b)
{
    if (a <= b)
    {
        if (a == b) {
            cout << a << endl;
            return;
        }
        cout << a << endl;
        a = a + 1;
        lol(a, b);
    }


    if (a >= b)
    {
        if (a == b) {
            cout << a << endl;
            return;
        }
        cout << a << endl;
        a = a - 1;
        lol(a, b);
    }

}
int main()
{
    setlocale(LC_ALL, "rus");
    int a;
    int b;
    cout << "Введите число А : ";
    cin >> a;
    cout << "\nВведите число Б : ";
    cin >> b;
    cout << "\n Вот что получилось : ";
    lol(a, b);
    //cout << res << endl;
    return 0;

}