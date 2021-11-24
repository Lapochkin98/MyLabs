#include <iostream>
#include <fstream>
#include <string>
using namespace std;

struct train {
    int number;
    string name;
    string time1;
    string time2;
};
int main()
{
    setlocale(LC_ALL,"rus");
    const int n = 4;
    struct train table[n];
    for (int i = 0; i < n; i++)
    {
        cout << "Номер поезда: \n";
        cin >> table[i].number;
        cout << "Имя поезда:\n";
        cin >> table[i].name;
        cout << "Время прибития:\n";
        cin >> table[i].time1;
        cout << "Время отбытия:\n";
        cin >> table[i].time2;
    }
    ofstream outfile("train.txt");
    if (!outfile.is_open()) 
    {
        cout << "Error" << endl;
    }
    else
    {
        for (int i = 0; i < n; i++)
        {
            outfile << table[i].number << " " << " " << table[i].name << " " << " " << table[i].time1 << " " << " " << table[i].time2 << endl;
        }
    }

    return 0;
}