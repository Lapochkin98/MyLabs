#include <iostream>
#include <time.h>
#include <cstdlib>
#include <string>
#include <stdio.h>
#include <stdlib.h>
using namespace std;
void sort(int left, int right, double massiv[30])
{
	int pivot; // разрешающий элемент
	int l_hold = left; //левая граница
	int r_hold = right; // правая граница
	pivot = massiv[left];
	while (left < right) // пока границы не сомкнутся
	{
		while ((massiv[right] >= pivot) && (left < right))
			right--; // сдвигаем правую границу пока элемент [right] больше [pivot]
		if (left != right) // если границы не сомкнулись
		{
			massiv[left] = massiv[right]; // перемещаем элемент [right] на место разрешающего
			left++; // сдвигаем левую границу вправо
		}
		while ((massiv[left] <= pivot) && (left < right))
			left++; // сдвигаем левую границу пока элемент [left] меньше [pivot]
		if (left != right) // если границы не сомкнулись
		{
			massiv[right] = massiv[left]; // перемещаем элемент [left] на место [right]
			right--; // сдвигаем правую границу вправо
		}
	}
	massiv[left] = pivot; // ставим разрешающий элемент на место
	pivot = left;
	left = l_hold;
	right = r_hold;
	if (left < pivot) // Рекурсивно вызываем сортировку для левой и правой части массива
		sort(left, pivot - 1, massiv);
	if (right > pivot)
		sort(pivot + 1, right, massiv);
};
void poisk(int length, double massiv[], int left, int right, int jk, int key)
{
	while (1)
	{
		int midd = (left + right) / 2;
		if (key < massiv[midd])
		{
			right = midd - 1;
		}
		else
		{
			if (key > massiv[midd])
			{
				left = midd + 1;
			}
			else
			{
				cout << "Число найдено\n";
				break;
			}
		}
		if (left > right)
		{
			cout << "Число не найдено\n";
			break;
		}
	}
}
void Rec()
{
	srand(time(NULL));
	const int length = 30;
	double massiv[length][length];
	int midd = 0;
	int left = 0;
	int right = 29;
	int count1 = 1;

	//Random
	int sign;
	for (int i = 0; i < length; i++)
	{
		for (int j = 0; j < length; j++)
		{
			sign = rand() % 2;
			massiv[i][j] = rand() % 100;
			if (sign == 1)
			{
				massiv[i][j] = massiv[i][j];
			}
			if (sign == 0)
			{
				massiv[i][j] *= -1;
			}
		}
	}
	//Сортируем массив
	int temp;
	for (int jk = 0; jk < length; jk++)
	{
		sort(left, right, massiv[jk]);
	}

	cout << "\nВаш отсортированный массив: \n";
	for (int i = 1; i < length; i++)
	{
		cout << count1 << ")";
		for (int j = 0; j < length; j++)
		{
			cout << " " << massiv[i][j] << " ";
		}
		cout << endl << endl;
		count1++;
	}
	//Поиск
	int key;
	cout << "\n\nКакой элемент ищем: ";
	cin >> key;
	int count2 = 1;
	for (int jk = 0; jk < length; jk++)
	{
		cout << count2 << ")";
		poisk(length, massiv[jk], left, right, jk, key);
		count2++;
	}
	Rec();
};
int main()
{
	setlocale(LC_ALL, "RUS");
	Rec();
	return 0;
}