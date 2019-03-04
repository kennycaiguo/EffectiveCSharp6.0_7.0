#pragma once
#include <string>
#include "B.h"

class Derived : public B
{
	std::string msg;

public:
	Derived(std::string msg) : msg("‰Šú‰»Žq‚ÅÝ’è")
	{
		this->msg = msg;
	}

protected:
	void VFunc() override
	{
		std::cout << msg;
	}
};