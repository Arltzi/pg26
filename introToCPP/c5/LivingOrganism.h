#pragma once
#include "Utility.h"
#include "Types.h"
#include "DamageInterface.h"

class LivingOrganism : 
	public IDamageInterface
{
public: 
	LivingOrganism() = delete;
	~LivingOrganism();
	// paramaterized constructors
	LivingOrganism(int age);
	LivingOrganism(string name, int age);
	// copy constructor
	LivingOrganism(const LivingOrganism& liveOrgToCopy);
	// copy assignment operator
	LivingOrganism& operator=(const LivingOrganism& liveOrgToCopy);

	// getters & setters
	int GetLifespan();
	void SetLifespan(int lifespan);

	string GetName();
	void SetName(string newName);

	// OVERRIDES

	virtual void Breathe();
	virtual void TakeDamage() override;

protected:

	int mAge;
	string mName;
};

