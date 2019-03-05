#pragma once

class B
{
protected:
	B()
	{
		VFunc();
	}

	virtual void VFunc() = 0;
};