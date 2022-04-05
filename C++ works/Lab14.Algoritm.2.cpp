#include <iostream>

#include <algorithm>

using namespace std;

int comp1(const void* a, const void* b) {

return (*(int*)a - *(int*)b);

}

// функция с алгоритмом двоичного поиска

int Search_Binary(int arr[], int left, int right, int key)

{

int midd = 0;

while (1)

{

midd = (left + right) / 2;

if (key < arr[midd]) // если искомое меньше значения в ячейке, то мы смещаем правую границу поиска

right = midd - 1; // смещаем правую границу поиска

else if (key > arr[midd]) // если искомое больше значения в ячейке, то мы смещаем левую границу поиска

left = midd + 1;

else

return midd; // функция возвращает индекс ячейки

if (left > right) // если границы сомкнулись, то значение возвращает -1

return -1;

}

}

int main()

{


setlocale(LC_ALL, "rus");

const int a = 20;

int array[a];

int key = 0;

int sort = 0; // индекс ячейки с искомым значением

for (int i = 0; i < a; i++)

{

array[i] = rand() % 99;

//array[i] = i + 1;

cout << " " << array[i];

}

cout << endl;

qsort(array, a, sizeof(int), comp1);

for (int i = 0; i < a; i++)

cout << array[i] << endl;

cout << "\n\nВведите любое число: ";

cin >> key;

sort = Search_Binary(array, 0, a, key);

if (sort >= 0)

cout << "Указанное число находится в ячейке с индексом: " << sort << "\n\n";

else

cout << "В массиве нет такого числа!\n\n";

return 0;

}