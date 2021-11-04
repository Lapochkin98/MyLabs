#include <iostream>
#include <stdlib.h>
#include <cstdlib>
#include <Algorithm>
#include <ctime>
using namespace std;

int comp1 (const void * a, const void * b) 
{
    return ( *(int*)a - *(int*)b );
}
int comp2 (const void * a, const void * b)
{
    return ( *(int*)b - *(int*)a );
}
int main()
{
    int random1[30] = {};
    int random2[30] = {};
 
 srand(time(NULL));
 cout << "Первый массив" << endl;
 for (int i = 0; i < 30; i++)
 {
    random1[i] = rand(); 
    cout << random1[i] << endl;
 }
 cout << "Второй массив" << endl;
 for (int q = 0; q < 30; q++)
 {
     random2[q] = rand();
     cout << random2[q] << endl;
 }
qsort(random1, 30, sizeof(int), comp1);
cout << "В порядке возрастания" << endl;
for (int i = 0; i < 30; i++)
 { 
    cout << random1[i] << endl;
 }
qsort(random2, 30, sizeof(int), comp2);
cout << "В порядке убывания" << endl;
for (int q = 0; q < 30; q++)
 {
     cout << random2[q] << endl;
 }


 
 return 0;
}