/**
    VFS Intro to C++
    Purpose: Pointer exercises using a class

    @class Intro to Programming in C++
    @version 1.1
*/

#include <iostream>
#include "Utility.h"

class Dog
{
public:

	Dog()
	{
		mNoises = 0;
	}
	
	void Woof()
	{
		std::cout << "WOOF!" << std::endl;
		++mNoises;
	}

private:

	int mNoises;

};

//
// EXECISE ONE
//

//
// create a function called "CreateDog" that returns an instance of "Dog" using dynamically allocated memory
//

Dog* CreateDog()
{
	//create doggy on heap
	return new Dog();
}


//
// EXECISE TWO
//

//
// create a function called "BarkThreeTimes" that uses an instance returned from "CreateDog" and then makes the dog bark three times
//
void BarkThreeTimes(Dog* doggy)
{
	//iterate over one doggy* thrice and call woof()
	for (int i = 0; i < 3; i++)
	{
		doggy->Woof();
	}
}

//
// EXECISE THREE
//

//
// 1. create a function called "ThreeDogsBark2" that takes three "Dog" pointers as parameters and then makes each dog bark once
// 2. create a function called "ThreeDogsBark1" that creates three dogs using "CreateDog" and then passes them to "ThreeDogsBark2"
void ThreeDogsBark2(Dog* doggy1, Dog* doggy2, Dog* doggy3)
{
	//call woof() on each passed doggy*
	doggy1->Woof();
	doggy2->Woof();
	doggy3->Woof();
}

void ThreeDogsBark1()
{
	//create 3 heap doggies using createdog()
	Dog* doggy1 = CreateDog();
	Dog* doggy2 = CreateDog();
	Dog* doggy3 = CreateDog();

	//call threedogsbark2
	ThreeDogsBark2(doggy1, doggy1, doggy3);

	//delete 3 heap doggies
	delete doggy1, doggy2, doggy3;
}

//
// EXECISE FOUR
//

// create a function called "ThreeDogsBarkStack" that creates three "Dog" instances on the stack and then passes them to "ThreeDogsBark2"
void ThreeDogsBarkStack()
{
	// create 3 dog instances on stack
	Dog doggy1;
	Dog doggy2;
	Dog doggy3;

	// create 3 pointers to the addresses of the stack doggies
	// this is needed to pass those doggies into threedogsbark2(), which only takes pointers
	Dog* pdoggy3 = &doggy3;
	Dog* pdoggy1 = &doggy1;
	Dog* pdoggy2 = &doggy2;

	ThreeDogsBark2(pdoggy1, pdoggy2, pdoggy3);
}

int main()
{
	//test func 1
	//should print an address
	Dog* doggy0 = CreateDog();
	PRINT_LINE(doggy0); 
	delete doggy0;

	//test funcs 2
	//should print 3x WOOF!
	Dog* doggy1 = CreateDog();
	BarkThreeTimes(doggy1);
	delete doggy1; 
	
	//test func 3
	//should print 3x WOOF!
	ThreeDogsBark1(); //deletes its own local doggies

	//test func 4
	//should print 3x WOOF!
	ThreeDogsBarkStack(); //no heap instances to delete

	return 0;
}