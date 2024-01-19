// INCLUDES
#include "Utility.h"

// NAMESPACES
using namespace std;

// NOTES:
// default class is private
// private - only class itself can access
// protected - inherited classes can access too
// public - anything can access
// friend - can access private members and functions of other private classes
// one file as header, one file as implementation, then can access

class Person
{
public: 
	// constructor called when class is added to memory
	Person();

	// destructor called when class is cleaned from memory
	~Person();

	string mName = "";
	void Introduction();

protected:
	float mWallet;
	void EatFood();

private:
	int mSerenitySpace;
	bool HideDeadBody();
};