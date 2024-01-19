// INCLUSIONS
#include "Utility.h"
#include "Person.h"

// forward declarations
void IfFunction();
void IfElseFunction();
void ForLoopFunc();
void DoSomethingWithPerson();

int main()
{
	//IfElseFunction();
	//ForLoopFunc();
	DoSomethingWithPerson();
}

void IfFunction()
{

}

void IfElseFunction()
{
	bool firstCondition = true;
	bool secondCondition = true;

	if (firstCondition)
	{
		PRINT_LINE("First condition true")
	}
	else if(secondCondition)
	{
		PRINT_LINE("Second condition true")
	}
	else
	{
		PRINT_LINE("All conditions false")
	}
}

void ForLoopFunc()
{
	for (int i = 0; i < 10; cout << i)
	{
		i += 1;
	}
}

void DoSomethingWithPerson()
{
	// stack allocation
	Person Rohit;
	Rohit.mName = "Rohit";
	Rohit.Introduction();
}

void DoWhile()
{
	//do {
		// statement to execute
	//} while ();
	// put condition inside while
	// will always execute do before running loop, therefore do content will always run at least once
}

class PG26 
{
	int NumberOfStudents;
	void Code();
};

class GD74
{
	int NumberOfDesigners;
	int NumberOfArtists;
	int NumberOfProjectManagers;
	int AnnoyProgrammers();
};

class DataHolder 
{
	float classFloat;
	int classInteger;
	bool classBool;

	int DoSomething() 
	{

	}
};

// header file is .h or .hpp in c++