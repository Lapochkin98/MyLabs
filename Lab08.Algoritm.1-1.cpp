#include <iostream>
#include <string>
#include <cstring>
using namespace std;
int mystrlen(const char* str) {
    int size = 0;
    while(*str++) ++size;
    return size; }
int main() {
    const char* str1 = "Manulov YT";
    cout << mystrlen(str1) << " символов."<< endl;
return 0; }