#include <iostream>
using namespace std;
struct Data {
    int a;
}; struct Tree {
    Data d;
    Tree* left;
    Tree* right;
}; void Add(Tree**, Data&);
void Print(Tree*);
int main() {
    setlocale(0, "");
    Tree* u = 0; //указатель на корень
    int n;
    cout << "Введите количество элементов дерева: " << endl;
    cin >> n;
    for (int i = 0; i < n; i++) {
        Data d;
        cout << "Введите элемент: " << endl;
        cin >> d.a;
        Add(&u, d);
    } cout << "Дерево: " << endl;
    Print(u);
    return 0;
} void Add(Tree** u, Data& x) {
    Tree* p = *u;
    if (p == 0) { // Дерево пусто - добавляемый новый элемент станет корнем дерева
        p = new Tree;
        p->d.a = x.a;
        p->left = 0;
        p->right = 0;
        *u = p;
        return;
    } Tree* p1 = 0;
    bool priznak = false; // признак того, что такой элемент уже имеется
    while (p && !priznak) {
        p1 = p;
        if (x.a == p->d.a)
            priznak = true;
        else
            if (x.a < p->d.a)
                p = p->left;
            else
                p = p->right;
    } if (priznak) return;
    // Создание нового узла
    Tree* pnew = new Tree;
    pnew->d.a = x.a;
    pnew->left = 0;
    pnew->right = 0;
    if (x.a < p1->d.a) // присоединить к левому поддереву
        p1->left = pnew;
    else              // присоединить к правому поддереву
        p1->right = pnew;
} void Print(Tree* u) {
    if (u) {
        Print(u->left);
        cout << u->d.a << endl;
        Print(u->right);
    }
}