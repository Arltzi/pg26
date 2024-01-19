// INCLUDES
#include "Person.h"
#include "Utility.h"

// to write function definition
// [return type] [ClassName]::[FunctionName][(arguments)]

// Person() constructor
Person::Person()
{
	PRINT_LINE("person constructed");
	mName = "";
	mWallet = 0;
	mSerenitySpace = 0;
}

Person::~Person()
{
	PRINT_LINE("person destructed");
}

void Person::Introduction()
{
	PRINT_LINE("Hi my name is " + mName);
}

void Person::EatFood()
{
	cout << "munch munch munch" << "\n";
}

bool Person::HideDeadBody()
{
	PRINT_LINE("I have successfully terminated a designer");
	return true;
}