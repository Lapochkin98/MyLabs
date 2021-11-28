#include <iostream>
using namespace std;

struct uzel {

    int number;

    uzel* next;

    uzel(int number) :
        number(number), next(NULL) {}
};

struct list
{
    uzel* first;
    uzel* last;

    list() : first(nullptr), last(nullptr) {}

    bool is_empty() {
        return first == nullptr;
    }

    void AddToBack(int number)
    {
        uzel* p = new uzel(number);
        if (is_empty()) {
            first = p;
            last = p;
            return;
        }
        last->next = p;
        last = p;
    }

    void AddToStart(int number)
    {
        uzel* p = new uzel(number);
        p->number = number;
        p->next = first;
        first = p;
    }

    void Out()
    {
        if (is_empty()) return;
        uzel* p = first;
        while (p) {
            cout << p->number << " ";
            p = p->next;
        }
    }
};

int main()
{
    setlocale(LC_ALL, "");
    int times, num;
    bool Zero = false;
    list spisok;
    cout << "Введите количество элементов в списке : ";

    cin >> times;

    for (int i = 1; i < times + 1; i++)
    {
        cout << "Введите число № " << i << " : ";
        cin >> num;
        if (num == 0) Zero = true;
        if (Zero == true) spisok.AddToStart(num);
        if (Zero == false) spisok.AddToBack(num);
    }

    cout << "Числа в списке : ";
    spisok.Out();
    cout << endl;
    system("pause");
}