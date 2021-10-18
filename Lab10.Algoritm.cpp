#include <iostream>
#include <string>

using namespace std;

struct train {
    int number;
    string name;
    string time1;
    string time2;
};

int main() {
    const int n = 3;
    struct train table[n];

    for (int i = 0; i < n; i++) {
        cin >> table[i].number >> table[i].name >> table[i].time1 >> table[i].time2;
    }

    for (int i = 0; i < n; i++) {
        cout << table[i].number << " " << table[i].name << " " << table[i].time1 << " " << table[i].time2 << endl;
    }

    string station;
    cin >> station;
    for (int i = 0; i < n; i++){
        if (table[i].name == station){
            cout << table[i].number << " " << table[i].name << " " << table[i].time1 << " " << table[i].time2 << endl;
        }
    }


    return 0;
}
