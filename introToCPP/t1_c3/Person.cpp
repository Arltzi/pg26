#include "Person.h"
#include "Utility.h"

Person::Person()
{
	mAge = 50;
	mName = "x";
	PRINT_LINE("Person created");
}

Person::~Person()
{

}

int Person::GetAge()
{
	return mAge;
}

string Person::GetName()
{
	return mName;
}

void Person::SetAge(int newAge)
{
	mAge = newAge;
}

void Person::SetName(string newName)
{
	mName = newName;
}
