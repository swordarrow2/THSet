#include "Exports.h"
#include "THCheater.h"

int FindGameProcess(int pid) {
	return THCheater::GetInstance().FindProcess(pid);
}
int SetPlayer(int i) {
	return THCheater::GetInstance().SetPlayer(i);
}

int SetFPS(int fps) {
	return THCheater::GetInstance().SetFPS(fps);
}
