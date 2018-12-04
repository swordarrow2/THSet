#pragma once

#define THAPI _declspec(dllexport)

extern "C" {
	THAPI int FindGameProcess(int pid);
	THAPI bool ReadValues();
	THAPI bool WriteValues();
	THAPI int GetLife();
	THAPI int SetFPS(int life);
	THAPI int SetPlayer(int i);
}
