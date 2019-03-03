#include "pch.h"
#include <iostream>
#include "CriticalSection.h"


CriticalSection::CriticalSection()
{
	EnterCriticalSection();
}


CriticalSection::~CriticalSection()
{
	ExitCriticalSection();
}

void CriticalSection::ExitCriticalSection()
{
	std::cout << "ExitCriticalsection()\n";
}
void CriticalSection::EnterCriticalSection()
{
	std::cout << "EnterCriticalsection()\n";
}

