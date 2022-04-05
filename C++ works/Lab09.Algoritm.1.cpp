#include <iostream>
#include <set>
using namespace std;

int main(){
    set <int> s;
    int n;
    cout << "Введите размер конта: " << endl;
    cin >> n; 
    for (int i=0; i<n; i++) {
        int x;
        cout << "Ваше число: " << endl;
        cin >> x;
        s.insert(x);
    }
    for (auto now = s.begin() ; now != s.end() ; now++){
        cout << *now << ' ';
    }
return 0;
}