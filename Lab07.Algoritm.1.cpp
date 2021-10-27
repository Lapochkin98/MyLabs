#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "rus");
	const int row = 3;
	const int col = 5;
	int b[row][col], v[row][col];
	int min, a1, a2;
	cout << "Введите массив размером 3 на 5 : " << endl;
	for (int i = 0; i < row; i++)
	{
		for (int j = 0; j < col; j++)
			cin >> b[i][j];
	}
	min = b[0][0];
	for (int i = 0; i < row; i++)
	{
		for (int j = 0; j < col; j++)
			if (min > b[i][j])
			{
				min = b[i][j];
				a1 = i;
				a2 = j;
			}
	}
	for (int i = 0; i < row; i++)
	{
		for (int j = 0; j < col; j++)
		{
			v[i][j] = b[i][j];
			if (i == a1 || j == a2) v[i][j] = 0;
		}
	}
	for (int i = 0; i < row; i++)
	{
		for (int j = 0; j < col; j++)
		{
			if (v[i][j] != 0) cout << v[i][j] << " ";
			else cout << " ";
		}
		cout << endl;
	}
	return 0;
}