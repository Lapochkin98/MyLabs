#include <iostream>

using namespace std;

int main()
{
    const int size = 20;
    int array[size], var;
    bool label = true;
    cout << "Введите 20 чисел в интервале от 10 до 100: " << endl << endl;
    for(int i = 0; i < size; i++)
    {
        cout << "Ввод:  ";
        cin >> var;
        if(var >= 10 && var <= 100)
        {
            array[i] = var;
            for(int j = 0; j < i; j++)
            {
                if(array[j] == array[i])
                    label = false;
            }
            if(label == true)
                cout << array[i] << endl;
        }
        else
        {
            cout << "Вы не соблюдаете интервал" << endl;
            i--;
        }
        label = true;
    }
    return 0;
}