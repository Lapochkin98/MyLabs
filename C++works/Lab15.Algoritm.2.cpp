#include <iostream>
using namespace std;

double rec(int sum, int count) {
    int num;
    cin >> num;
    if (!num)
        return (double)sum / count;
    return rec(sum + num, count + 1);
} int main() {
    setlocale(LC_ALL, "rus");
    cout << "Среднее: " << rec(0, 0);
}