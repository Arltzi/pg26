#pragma once
#include "Utility.h"

class Person
{

public:

	// constructor destructor
	Person();
	~Person();

	// getters
	int GetAge();
	string GetName();

	// setters
	void SetAge(int newAge);
	void SetName(string newName);

private:

	int mAge;
	string mName;
	int mSizeAdder;
};

