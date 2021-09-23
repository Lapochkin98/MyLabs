#include <iostream>

void main()
{
	STARTUPINFO cif;
	ZeroMemory(&cif,sizeof(STARTUPINFO));
	PROCESS_INFORMATION pi;
	if (CreateProcess("c:\\windows\\notepad.exe",NULL,
		NULL,NULL,FALSE,NULL,NULL,NULL,&cif,&pi)==TRUE)
	{
		cout << "process" << endl;
		cout << "handle " << pi.hProcess << endl;
		Sleep(1000);				// подождать
		TerminateProcess(pi.hProcess,NO_ERROR);	// убрать процесс
	}
}