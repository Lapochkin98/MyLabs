#include <iostream>
#include <fstream>
#include <string>
using namespace std;
struct train
{
    int number;
    string name;
    string time1;
    string time2;
};
int main()
{
    setlocale(LC_ALL, "Rus");
    const int n = 4;
    struct train table[n];
    ifstream infile("train.txt");
    for (int i = 0; i < n; i++)
    {
        infile >> table[i].number;
        infile >> table[i].name;
        infile >> table[i].time1;
        infile >> table[i].time2;
    }
    int station;
    cout << "Введите номер поезда: ";
    cin >> station;
    cout << "Вот следующие данные о нём: ";
    for (int i = 0; i < n; i++)
    {
        if (table[i].number == station)
        {
            cout << table[i].number << " " << table[i].name << " " << table[i].time1 << " " << table[i].time2;
        }
    }
    return 0;
}