#include "Character.h"
#include "Utility.h"

Character::Character(string name, int strength, float health, float maxHealth, float mana, float maxMana)
{
	PRINT_LINE("Parameterized constructor");
	mName = name;
	mStrength = strength;
	mHealth = health;
	mMaxHealth = maxHealth;
	mMana = mana;
	mMaxMana = maxMana;
}

Character::Character(const Character& otherCharacter)
{
	PRINT_LINE("Copy constructor");
	mName = otherCharacter.mName + " but worse.";
	mStrength = otherCharacter.mStrength * 0.5f;
	mHealth = otherCharacter.mHealth * 0.5f;
	mMaxHealth = otherCharacter.mMaxHealth * 0.5f;
	mMana = otherCharacter.mMana * 0.5f;
	mMaxMana = otherCharacter.mMaxMana * 0.5f;
}

/* This will also construct with mName
Character::Character(string name) : mName(name)
{
}d
*/

Character::~Character()
{
	PRINT_LINE("Character destroyed");
}


// setters

void Character::SetName(string newValue)
{
	mName = newValue;
}

void Character::SetStrength(int newValue)
{
	mStrength = newValue;
}

void Character::SetHealth(float newValue)
{
	mHealth = newValue;
}

void Character::SetMana(float newValue)
{
	mMana = newValue;
}

void Character::SetMaxHealth(float newValue)
{
	mMaxHealth = newValue;
}

void Character::SetMaxMana(float newValue)
{
	mMaxMana = newValue;
}

// getters

string Character::GetName()
{
	return mName;
}

int Character::GetStrength()
{
	return mStrength;
}

float Character::GetHealth()
{
	return mHealth;
}

float Character::GetMana()
{
	return mMana;
}

float Character::GetMaxHealth()
{
	return mMaxHealth;
}

float Character::GetMaxMana()
{
	return mMaxHealth;
}

// operator overloads

void Character::operator=(const Character& otherCharacter)
{
	PRINT_LINE("operator overload copy constructor");
	mName = otherCharacter.mName + " but better.";
	mStrength = otherCharacter.mStrength * 2;
	mHealth = otherCharacter.mHealth * 2;
	mMaxHealth = otherCharacter.mMaxHealth * 2;
	mMana = otherCharacter.mMana * 2;
	mMaxMana = otherCharacter.mMaxMana * 2;
}

Character& Character::operator+(const Character& otherCharacter)
{
	PRINT_LINE("Plus operator called");
	mName = mName + " fused with " + otherCharacter.mName;
	mStrength += otherCharacter.mStrength;
	mHealth += otherCharacter.mHealth;
	mMaxHealth += otherCharacter.mMaxHealth;
	mMana += otherCharacter.mMana;
	mMaxMana += otherCharacter.mMaxMana;

	return *this;
}

std::ostream& operator<<(std::ostream& stream, const Character& characterToPrint)
{
	stream << "==========================" << "\n";
	stream << "Name: " << characterToPrint.mName << "\n";
	stream << "Strength: " << characterToPrint.mStrength << "\n";
	stream << "Health: " << characterToPrint.mHealth << " / " << characterToPrint.mMaxHealth << "\n";
	stream << "Mana: " << characterToPrint.mMana << " / " << characterToPrint.mMaxMana << "\n";
	stream << "==========================" << "\n";
	
	return stream;
}

// functions

void ButcherCharacter(Character* character)
{
	PRINT_LINE("Brutally butchered " << character->GetName());
	delete character;
}

