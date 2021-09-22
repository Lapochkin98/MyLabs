#include <iostream>
#include <math.h>

using namespace std;

int main() {
    int i = 1;
    double x, sum = 0;
    double e = 0.15;
    cin >> x;
    do {
        sum += pow(x, 2*i) / (2 * i);
        i++;    
    } while (sum >= e);

    cout << sum << endl;
    return 0;
}