#include <iostream>
#include <iomanip>
#include <ctime>

using namespace std;

int main(){
    const int twelve=12;
    int arr[twelve],x,i;
    cout << "Выберите метод заполнения: 1-руками, 2-фулл рандом" <<endl;
    cin >> x;
    if (x==1){
        i=0;
        for (i=0; i<twelve; i++){
        cin >> arr[i];
        if(arr[i] <= 0 || arr[i] >= 99)
        
            {
                cout << "Выход за допустимые пределы\n";
                i--;
            }
    }
    }
    else 
        
{
srand(time(NULL));

const int SIZE = 10;
int arr[SIZE];

bool alreadyThere;

for (int i = 0; i < SIZE; )
{
alreadyThere = false;
int newRanomValue = rand() % 20;

for (int j = 0; j < i; j++)
{
if (arr[j]==newRanomValue)
{
alreadyThere = true;
break;
}
}

if (!alreadyThere)
{
arr[i] = newRanomValue;
i++;
}

}

for (int i = 0; i < SIZE; i++)
{
cout << arr[i] << endl;
}

}

    
}