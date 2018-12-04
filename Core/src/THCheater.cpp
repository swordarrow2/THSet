#include "THCheater.h"
#include <TlHelp32.h>

const LPVOID addrFPS = reinterpret_cast<LPVOID>(0x004CFEB8);
const LPVOID addrPlayer = reinterpret_cast<LPVOID>(0x004E7450);

THCheater& THCheater::GetInstance() {
	static THCheater instance;
	return instance;
}

THCheater::~THCheater() {
	if (_hProcess)
		CloseHandle(_hProcess);
}

int THCheater::FindProcess(int pid) {
	if (pid == 0) return pid;
	if (_hProcess) {
		CloseHandle(_hProcess);
		_hProcess = NULL;
	}
	_hProcess = OpenProcess(PROCESS_VM_READ | PROCESS_VM_WRITE | PROCESS_VM_OPERATION, FALSE, pid);
	if (_hProcess == NULL) return pid;
	return 666;
}

int THCheater::SetFPS(int fps) {
	double i = 40;//((double)1) / fps;
	DWORD oldProtect, oldProtect2;
	WriteProcessMemory(_hProcess, addrFPS, &i, sizeof(i), NULL);
	return 66666;
}
int THCheater::SetPlayer(int i) {
	int pl = i;
	WriteProcessMemory(_hProcess, addrPlayer, &pl, sizeof(pl), NULL);

	return 66666;
}
