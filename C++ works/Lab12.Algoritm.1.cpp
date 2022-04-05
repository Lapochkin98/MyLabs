#include <iostream>
#include<cmath>
#include<math.h>
using  namespace std;

double first(double x)
{
    return sin(x);
}

double leftpraym(double a, double b, int n)
{
    double h = (b - a) / n;
    double sum = 0;
    for (int i = 0; i <= n - 1; i++)
    {
        sum += h * first(a + i * h);
    }
    return sum;
}

double rightparam(double a, double b, int n)
{
    double h = (b - a) / n;
    double sum = 0;
    for (int i = 0; i <= n; i++)
    {
        sum += h * first(a + i * h);
    }
    return sum;
}

double trapec(double a, double b, int n)
{
    double h = (b - a) / n;
    double sum = 0;
    for (int i = 0; i <= n; i++)
    {
        sum += 2 * first(a + i * h);
    }
    sum *= h / 2;
    return sum;
}
double calceValue(double a, double b, int n)
{
    double h = (b - a) / n;
    double sum = 0;
    for (int i = 0; i++; i += h)
    {
        sum += 1 *(7-15) / 4; 
    }
    return sum;
}

double primitive(double a, double b, int n)
{
    double h = (b - a) / n;
    double sum = 0;
    for (int i = 0; i++; i += h)
    {
        
        sum += 1/2;
    }
    return sum;
}


int main()
{
    setlocale(LC_ALL, "rus");
    double a = 0.2;
    double b = 1;
    int n = 10;
    cout << "Метод левых треугольников: " << leftpraym(a, b, n) << endl;
    cout << "Метод правых треугольников: " << rightparam(a, b, n) << endl;
    cout << "Метод трапеции: " << trapec(a, b, n) << endl;
    cout << "calceValue:" << calceValue(a, b, n) << endl;
    cout << "primitive: "  << primitive(a, b, n) << endl;

    system("pause");
    return 0;
}