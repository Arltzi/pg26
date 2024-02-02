/**
	Purpose: Constructor exercises
	@class VFS Intro to C++
*/

#include <iostream>
#include "Utility.h"

// FORWARD DECLARATIONS
void MyClassTrilogyUsage();
void MyClassDisallowedTester();
void PrintChildClass();

// INJECTION POINT
int main()
{
	// EXERCISE 1
	MyClassTrilogyUsage();

	// EXERCISE 2
	MyClassDisallowedTester();

	// EXERCISE 3
	PrintChildClass();
};

// CLASSES

class MyClass1
{
public:
	int x;
	int y;
	int z;
};

//
// IMPORTANT! please note that for this exercise any copy constructor or copy assignment operator you implement should assign all values from the other instance to itself
//

//
// EXECISE ONE
//

//
// duplicate "MyClass1" and call it "MyClassTrilogy" but give it a constructor, destructor, copy constructor and a copy assignment operator
//
// create a function called "MyClassTrilogyUsage" that does the following:
//
// 1. create a variable "myClassA" of type "MyClassTrilogy"
// 2. set the variables in "myClassA" 
// 3. print out the ints of "myClassA" to verify the variables are set
// 4. create a variable "myClassB" of type "MyClassTrilogy" but use the copy constructor (using "myClassA" as the object to copy)
// 5. print out the ints of "myClassB" to see if the copy constructor did it's job
// 4. assign "myClassA" to "myClassB"
// 5. print out the ints of "myClassB" again to see if the copy assignment operator did it's job
//

class MyClassTrilogy
{
public:
	// member declarations
	int x;
	int y;
	int z;

	// default constructor, vs recognizes that it creates null member
	MyClassTrilogy() {}

	// default destructor
	~MyClassTrilogy() {}

	// copy constructor
	MyClassTrilogy(const MyClassTrilogy& copyClassTrilogy)
	{
		x = copyClassTrilogy.x + 10;
		y = copyClassTrilogy.y + 10;
		z = copyClassTrilogy.z + 10;
	}

	// copy assignment operator (im calling it the copyrator from now on)
	MyClassTrilogy& operator=(const MyClassTrilogy& copyClassTrilogy)
	{
		x = copyClassTrilogy.x + 100;
		y = copyClassTrilogy.y + 100;
		z = copyClassTrilogy.z + 100;
		return *this;
	}
};

void MyClassTrilogyUsage()
{
	// default constructor, then assignment, then test
	MyClassTrilogy MyClassA;
	MyClassA.x = 24;
	MyClassA.y = 25;
	MyClassA.z = 26;
	PRINT_LINE(MyClassA.x);
	PRINT_LINE(MyClassA.y);
	PRINT_LINE(MyClassA.z);

	// copy constructor & test
	MyClassTrilogy MyClassB(MyClassA);
	PRINT_LINE(MyClassB.x);
	PRINT_LINE(MyClassB.y);
	PRINT_LINE(MyClassB.z);

	// copyrator
	MyClassB = MyClassA;
	PRINT_LINE(MyClassB.x);
	PRINT_LINE(MyClassB.y);
	PRINT_LINE(MyClassB.z);
};

//
// EXECISE TWO
//

//
// 1. duplicate "MyClass1" and call it "MyClassDisallowed" and give it a destructor and a constructor that has an argument list that will initialize all of the members
// 2. add code to "MyClassDisallowed" that will disallow the default constructor and copy constructor
// 3. create several variables of type "MyClassDisallowed" using a default constructor, copy constructor and constructor with an arguement list.
// 4. comment out the constructors that do not compile
// 5. print out the ints of the variable of type "MyClassDisallowed" that compiled

class MyClassDisallowed
{
public:
	// member declarations
	int x;
	int y;
	int z;

	// disallowed default constructor
	MyClassDisallowed() = delete;

	// disallowed copy constructor
	MyClassDisallowed(const MyClassDisallowed& disallowedToCopy) = delete;
	
	// paramaterized constructor
	MyClassDisallowed(int nx, int ny, int nz) 
	{
		x = nx;
		y = ny;
		z = nz;
	}
};

void MyClassDisallowedTester()
{
	//MyClassDisallowed disallowedDefaultConstructor;

	// the only constructor that now works is the paramaterize constructor
	MyClassDisallowed disallowedParamaterizedConstructor(1, 2, 3);
	PRINT_LINE(disallowedParamaterizedConstructor.x);
	PRINT_LINE(disallowedParamaterizedConstructor.y);
	PRINT_LINE(disallowedParamaterizedConstructor.z);

	//MyClassDisallowed disallowedCopyConstructor(disallowedParamaterizedConstructor);
}

//
// EXECISE THREE
//

//
// 1. duplicate "MyClass1" and call it "MyClassParent" and add a constructor and destructor
// 2. make another class called "MyClassChild" that inherits from "MyClassParent" and adds a dynamically allocated float member variable
// 3. add a constructor and destructor to "MyClassChild"
// 4. create a variable of type "MyClassChild" and initialise the member variables
// 5.  print out the member variables of type "MyClassChild"

class MyClassParent
{
public:

	// member declarations
	int x;
	int y;
	int z;

	// default constructor and destructor, not deleted
	MyClassParent() {}
	~MyClassParent() {}
};

class MyClassChild : public MyClassParent
{
public:
	// member declaration
	float* numberWithADot = new float();

	// default constructor and destructor, not deleted
	MyClassChild() {}
	~MyClassChild() {}
};

void PrintChildClass()
{
	// create child using default constructor
	MyClassChild JustABaby;
	// assign all values
	JustABaby.x = 1;
	JustABaby.y = 2;
	JustABaby.z = 4;
	*JustABaby.numberWithADot = 8.0;

	// print all values
	PRINT_LINE(JustABaby.x);
	PRINT_LINE(JustABaby.y);
	PRINT_LINE(JustABaby.z);
	PRINT_LINE(*JustABaby.numberWithADot);
}