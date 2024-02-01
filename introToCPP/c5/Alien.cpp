#include "Alien.h"

Alien::~Alien()
{
}

Alien::Alien(string name, int age, Colour bloodColor) : LivingOrganism(name, age)
{
	mBloodColour = bloodColor;
	mTimeToDigest = 10.0f;
}

Alien::Alien(string name, int age, Colour bloodColor, float digestTime) : LivingOrganism(name, age)
{
	mBloodColour = bloodColor;
	mTimeToDigest = digestTime;
}

Alien::Alien(const Alien& alienToCopy) : LivingOrganism(alienToCopy)
{
	mName = alienToCopy.mName + " copy";
	mAge = alienToCopy.mAge;
	mBloodColour = alienToCopy.mBloodColour;
	mTimeToDigest = alienToCopy.mTimeToDigest;
}

Alien& Alien::operator=(const Alien& alienToCopy)
{
	mName = alienToCopy.mName + " assignment copy";
	mAge = alienToCopy.mAge;
	mBloodColour = alienToCopy.mBloodColour;
	mTimeToDigest = alienToCopy.mTimeToDigest;
	return *this;
}

Colour Alien::GetBloodColor()
{
	return mBloodColour;
}

void Alien::SetBloodColor(Colour newBloodColour)
{
	mBloodColour = newBloodColour;
}

float Alien::GetTimeToDigest()
{
	return mTimeToDigest;
}

void Alien::SetTimeToDigest(float newTimeToDigest)
{
	mTimeToDigest = newTimeToDigest;
}

void Alien::Breathe()
{
	LivingOrganism::Breathe();
	PRINT_LINE("ripley..... i see you... NOOOO flamethrower RAAAHHHHHHH");
}
