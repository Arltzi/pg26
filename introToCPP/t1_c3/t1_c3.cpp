#include "Utility.h"
#include "Person.h"

/*
int main()
{
	// stack allocation
	Person Lev;
	Person Monica;
	Person Rohit;
	Person Ron;

	// reference or alias
	// <type>& = alias
	// alias is the same data 
	Person JamesBond;
	Person& _007 = JamesBond;

	// heap allocation (new keyword)
	// heap allocation has no built in garbage collection, use delete foreach new

	Person* Rafael = new Person();
	Person* Luca = Rafael;
	void* ToddHoward = &Lev;

	// &<var> = memory address
	// *<pointer> = value
	// <type>& -> alias
	// <type>* -> pointer

	// same thing, use bottom one
	PRINT_LINE((*Rafael).GetAge());
	PRINT_LINE(Rafael->GetAge());

	PRINT_LINE(Luca);
	PRINT_LINE(&Luca);

	delete Rafael;
	PRINT_LINE(Luca->GetAge());

	int b = 25;
	int& ref = b;
	int* ptr = new int();
	int* ptr2 = &b;
	int* ptr3 = &ref;
	int MyNewInteger = *ptr2;
	int MyNextInteger = *ptr3;
}
*/