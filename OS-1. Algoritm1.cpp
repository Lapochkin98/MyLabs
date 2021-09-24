#include <iostream>
#include <windows.h>
using namespace std;
int main()
{
STARTUPINFO w = { 0 };
w.cb = sizeof(w);
PROCESS_INFORMATION p;
CreateProcess(NULL, "C:\\Program Files\\Microsoft Office\\root\\Office16\\EXCEL.EXE", NULL, NULL, true, 0, NULL, NULL, &w, &p);
system("pause");
return 0;
} 