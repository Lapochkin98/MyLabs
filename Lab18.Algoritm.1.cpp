#include <iostream>
#include <ctime>

int rand(int range_min, int range_max)
{
    return rand() % (range_max - range_min + 1) + range_min;
}

using namespace std;
int main()
{
    setlocale(LC_ALL, "");
    int size, n = 0, q = 0;
    cout << "Введите количество чисел: ";
    cin >> size;
    int* a = new int[size];
    srand(time(NULL));
    cout << "Исходные числа : ";
    for (int i = 0; i < size; i++)
    {
        a[i] = rand(-10, 10);
        if (a[i] % 2)
        {
            n++;
        }
        cout << a[i] << " ";
    }
    cout << endl;
    int* b = new int[n];
    cout << "Нечётные числа : ";
    for (int i = 0; i < size; i++)
    {
        if (a[i] % 2)
        {
            b[q] = a[i];
            cout << b[q] << " ";
            q++;
        }
    }
    delete[] a; a = 0;
    delete[] b; b = 0;
    return 0;
}