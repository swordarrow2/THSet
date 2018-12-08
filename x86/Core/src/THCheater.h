#pragma once

#include "stdafx.h"
#include <vector>

class THCheater {
public:
	static THCheater& GetInstance();

	~THCheater();

	int FindProcess(int pid);
	int SetFPS(int fps);
	int SetPlayer(int i);

private:
	THCheater() = default;
	DWORD _GetProcessIdByName(const WCHAR* processName);

private:
	HANDLE _hProcess = NULL;
};
