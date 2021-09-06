#include <iostream>
#include <string>
using namespace std;

int main() {
    setlocale (LC_ALL, "rus");
    int age;
    string name;
    cout << "Введите свое имя:";
    cin >> name;
    cout << "Введите свой возраст:";
    cin >> age;
    cout << "Привет, меня зовут " << name << ". Сейчас мне " << age << ". В том году было " << --age << ", а в следующем будет " << ++++age << endl;
    
    return 0;
}