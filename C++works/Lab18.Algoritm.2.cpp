#include <iostream>
#include <ctime>
using namespace std;
int stroka; int stolbec;

int rand(int range_min, int range_max)
{
    return rand() % (range_max - range_min + 1) + range_min;
}

int** gen(unsigned int stroka1, unsigned int stolbec2) {
    int** ptrary = new int* [stroka1];
    for (int i = 0; i < stroka1; i++) {
        ptrary[i] = new int[stolbec2];
    }
    return ptrary;
}

void gen(int** ary, unsigned int dim1) {
    for (int i = 0; i < dim1; i++) {
        delete[] ary[i];
    }
    delete[] ary;
}

int main()
{
    setlocale(LC_ALL, "rus");
    srand(time(NULL));
    int** matrix;
    cout << "Введите колличество строк двумерного массива: ";
    cin >> stroka;
    cout << "Введите колличество столбцов двумерного массива: ";
    cin >> stolbec;
    cout << "Ваш массив: \n";
    matrix = gen(stroka, stolbec);

    for (int i = 0; i < stroka; i++) {
        for (int j = 0; j < stolbec; j++) {
            matrix[i][j] = rand(-50, 50);
            cout << "|" << matrix[i][j] << " ";
        }
        cout << endl;
    }
    int min = matrix[0][0], max = matrix[0][0];

    for (int i = 0; i < stroka; i++) {
        for (int j = 0; j < stolbec; j++) {
            if (min < matrix[i][j]) min = matrix[i][j];
            if (max > matrix[i][j]) max = matrix[i][j];
        }
    }

    cout << "Сумма " << min << " и " << max << " = " << max + min;

    gen(matrix, stroka);
    return 0;
}