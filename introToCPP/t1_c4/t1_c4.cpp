#include "Character.h"
#include "Utility.h"

int main()
{
	/*
	Character* Mario = new Character("Mario", 5, 100, 100, 30, 30);
	Character* Bowser = new Character("Bowser", 100, 500, 0, 0, 500);
	Character* Peach = new Character("Peach", 5, 100, 200, 200, 100);

	Character* Pikachu = new Character("Pikachu", 1, 1, 1, 1, 1);
	Character* Ditto = new Character(
		"Ditto",
		Pikachu->GetStrength(),
		Pikachu->GetHealth(),
		Pikachu->GetMaxHealth(),
		Pikachu->GetMana(),
		Pikachu->GetMaxMana()
	);

	Character* HeapDitto = new Character(*Pikachu);
	Character StackDitto = *Pikachu;
	*/

	Character EmptyDitto("EmptyDitto", 0, 0, 0, 0, 0);
	Character Vegetable("Vegetable", 1, 2, 3, 4, 5);

	Vegetable + EmptyDitto;

	cout << Vegetable;

	// these two are the same, but different to line 21
	// EmptyDitto = *HeapDitto;
	// EmptyDitto.operator=(*HeapDitto);


	/*
	delete Mario;
	delete Bowser;
	delete Peach;
	delete Pikachu;
	delete Ditto;
	delete HeapDitto;
	*/

	/*
	Character* CharacterB;
	{
		Character CharacterA;
		CharacterB = &CharacterA;
	}
	CharacterB = nullptr;

	if (CharacterB != nullptr)
	{
		PRINT_LINE("Valid Pointer");
	}
	*/


	/*
	Mario->SetName("Mario");
	Mario->SetStrength(5);
	Mario->SetHealth(100);
	Mario->SetMaxHealth(100);
	Mario->SetMana(30);
	Mario->SetMaxMana(30);
	*/

	return 0;
}
