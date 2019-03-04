#pragma once
#include <iostream>

class B
{
protected:
	B()
	{
		VFunc();
	}

	virtual void VFunc()
	{
		std::cout << "B“à‚ÌVFunc";
	}
};