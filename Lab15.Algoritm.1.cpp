#include <iostream>
using namespace std;
int rec(int num) {
	if (num / 10 != 0)
		return num % 10 + rec(num / 10);
	else return num % 10;
}

int main() {
	setlocale(LC_ALL, "rus");
	cout << "Введите число: " << endl;
	int num;
	cin >> num;
	cout << "Сумма всех цифр: " << rec(num) << endl;
}