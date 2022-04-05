#include <iostream>
using namespace std;

double func(int n1, int n2)
{
	double sum = 0;
	if(n2 == 0)
	{
		return -1;
	}
	else
	{
		sum = n1 / n2;
		return sum;
	}
	
	
}
int main() 
{
	setlocale(LC_ALL,"rus");
	int n1 = 0, n2 = 0;
	cout << "Введите первое число: " << endl;
	cin >> n1;
	cout << "Теперь второе: " << endl;
	cin >> n2;
	
	double rez = func(n1,n2);
	if(rez == -1)
	{
		cout << "erorr" << endl;
	}
	else
	{
		cout << rez;
	}
	system("pause");
	return 0;
}