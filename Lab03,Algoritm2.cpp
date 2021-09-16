#include <iostream> // это 8 вариант
#include <math.h>
#include <iomanip>
using namespace std;

int main(){
setlocale(LC_ALL, "rus");
int i, n;
double s,x, l,w;
w=0.25;
n = 20;
x = 0.25;
for (i = 0; i <= n; i++) {
l = pow(-1, i) * pow(x,(2*i+1)) / (2*i+1);
s += l;
cout << l << setw(1) << endl;
}
cout << "Результат: " << s << endl;
return 0; }
