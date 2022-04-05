#include <iostream>
using namespace std;
//проверка симметричности матрицы
int main()
{ int n;
 int a[100][100]; bool b=true;
 cin>>n;
 
 for (int i=0;i<n;i++)
    for (int j=0;j<n;j++)
        cin>>a[i][j];
 
for (int i=0;i<n;i++)
    for (int j=i+1; j<n;j++)
      if (a[i][j] !=a[j][i]) b=false;
 if (b) cout<<"Да";
 else cout <<"Нет";
 return 0;
}