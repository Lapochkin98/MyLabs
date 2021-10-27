#include <iostream>
#include <set>
using namespace std;
int main()
{
	setlocale(LC_ALL, "rus");
	set <int> s1, s2, s3;
	int n, m;
	cout << "Задайте максимальный размер первого списка: ";
	cin >> n;
	cout << " " << endl;
	for (int i = 0; i < n; i++)
	{
		int a;
		cout << "Введите значение первого списка под номером " << i + 1 << " : ";
		cin >> a;
		s1.insert(a);
	}

	cout << " " << endl;
	cout << "Задайте максимальный размер второго списка: ";
	cin >> m;
	int k = 0;
	cout << " " << endl;
	for (int i = 0; i < m; i++)
	{
		int a;
		cout << "Введите значение вторго списка под номером " << i + 1 << " : ";
		cin >> a;
		s2.insert(a);
	}
	for (auto now = s1.begin(); now != s1.end(); now++) {
		for (auto now1 = s2.begin(); now1 != s2.end(); now1++) {
			if (*now == *now1) {
				s3.insert(*now);
			}
		}
	}
	cout << " " << endl;
	cout << "Общее количество элементов из первого и вторго списка: " << s3.size() << endl;
	system("pause");
	return 0;
}
