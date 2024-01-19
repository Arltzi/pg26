#include <iostream>
using namespace std;

#define CURLY_OPEN {
#define CURLY_CLOSED }
// can define functions
#define PRINT(X) cout << X << "\n"

// forward declaration
void Foo();
float Add(int, int);
float Subtract(int, int);
float Divide(int, int);
float Multiply(int, int);


int main() 
{
	int classroom_number = 7;
	long longer_int = 8;
	long long length_of_8_bytes = 100000;
	float its_a_float_man_i_dont_know_what_to_say = 1.0f;
	double get_used_to_this_naming_convention; // best practice is time as double
	short shorter_integer;

	Foo();
	Foo();
	Foo();
	Foo();
	Foo();
	PRINT(Add(7,7));
	PRINT(Subtract(7,7));
	PRINT(Divide(7,7));
	PRINT(Multiply(7,7));
	cout << Add(7, 7) << "\n";
	cout << Subtract(7, 7) << "\n";
	cout << Divide(7, 7) << "\n";
	cout << Multiply(7, 7) << "\n";
}

void Foo()
{
	cout << "bar \n";
}

float Add(int Param1, int Param2)
{
	return Param1 + Param2;
}

float Subtract(int p1, int p2)
{
	return p1-p2;
}

float Divide(int p1, int p2)
{
	return p1/p2;
}

float Multiply(int p1, int p2)
{
	return p1 * p2;
}
