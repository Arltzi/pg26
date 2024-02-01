#include "Predator.h"

Predator::~Predator()
{
}

Predator::Predator(string name, int age, bool isInvis) : LivingOrganism(name, age)
{
    mIsInvis = isInvis;
    mTopSpeed = 100.0f;
}

Predator::Predator(string name, int age, bool isInvis, float topSpeed) : LivingOrganism(name, age)
{
    mIsInvis = isInvis;
    mTopSpeed = topSpeed;
}

Predator::Predator(const Predator& predatorToCopy) : LivingOrganism(predatorToCopy)
{
    mName = predatorToCopy.mName + " copy";
    mAge = predatorToCopy.mAge;
    mIsInvis = predatorToCopy.mIsInvis;
    mTopSpeed = predatorToCopy.mTopSpeed;
}

Predator& Predator::operator=(const Predator& predatorToCopy)
{
    mName = predatorToCopy.mName + " copy";
    mAge = predatorToCopy.mAge;
    mIsInvis = predatorToCopy.mIsInvis;
    mTopSpeed = predatorToCopy.mTopSpeed;
    return *this;
}

bool Predator::GetIsInvis()
{
    return mIsInvis;
}

void Predator::SetIsInvis(bool newInvisState)
{
    mIsInvis = newInvisState;
}

float Predator::GetTopSpeed()
{
    return mTopSpeed;
}

void Predator::SetTopSpeed(float newTopSpeed)
{
    mTopSpeed = newTopSpeed;
}

void Predator::Breathe()
{
    PRINT_LINE("What the hell are YOU?");
}

void Predator::TakeDamage()
{
    PRINT_LINE("I do not bleed");
}
