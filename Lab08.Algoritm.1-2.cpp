#include <iostream>
#include <cstring>
using namespace std;

void connect(char *str1, char *str2);
int main() {
    setlocale(0, "rus");
    char str1[80] = "Manulov";
    char str2[80] = " YT";
    connect(str1, str2);
    cout << str1 << "\n";
    system("pause");
    return 0; } 
void connect(char *str1, char *str2) {
    int length1 = strlen(str1);
    for (int i = 0; i < strlen(str2); i++){
    *(str1 + length1 + i) = *(str2 + i); }
}