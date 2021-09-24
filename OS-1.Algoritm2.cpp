#include <iostream>
#include <windows.h>
#include "ShellAPI.h"

using namespace std;
int main()
{
ShellExecuteA(0, NULL, "C:\\Users\\dorak\\Desktop\\home.txt", NULL, NULL, SW_RESTORE);
system("pause");
return 0;
} 