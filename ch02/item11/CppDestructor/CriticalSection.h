#pragma once
class CriticalSection
{
public:
	CriticalSection();
	~CriticalSection();

private:
	void ExitCriticalSection();
	void EnterCriticalSection();
};

