#pragma once
#include "Utility.h"

class Character
{

public:

	// default constructor
	Character() = delete;

	// default destructor
	~Character();

	// parameterized constructor
	Character(
		string name,		
		int strength,
		float health, 
		float maxHealth,
		float mana, 
		float maxMana
	);

	// copy constructor
	Character(const Character& otherCharacter);

	// setters
	void SetName(string newValue);
	void SetStrength(int newValue);
	void SetHealth(float newValue);
	void SetMana(float newValue);
	void SetMaxHealth(float newValue);
	void SetMaxMana(float newValue);

	// getters
	string GetName();
	int GetStrength();
	float GetHealth();
	float GetMana();
	float GetMaxHealth();
	float GetMaxMana();
	
	// operator overloads
	void operator=(const Character& otherCharacter);
	Character& operator+(const Character& otherCharacter);
	friend std::ostream& operator<<(std::ostream& stream, const Character& characterToPrint);


private:
	string mName;
	int mStrength;
	float mHealth;
	float mMaxHealth;
	float mMana;
	float mMaxMana;
};