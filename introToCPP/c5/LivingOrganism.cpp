#include "LivingOrganism.h"

LivingOrganism::~LivingOrganism()
{
}

LivingOrganism::LivingOrganism(int age)
{
    mAge = age;
    mName = "defaultName";
}

LivingOrganism::LivingOrganism(string name, int age)
{
    mAge = age;
    mName = name;
}

LivingOrganism::LivingOrganism(const LivingOrganism& liveOrgToCopy)
{
    mAge = liveOrgToCopy.mAge;
    mName = liveOrgToCopy.mName + " copy";
}

LivingOrganism& LivingOrganism::operator=(const LivingOrganism& liveOrgToCopy)
{
    mName = liveOrgToCopy.mName + " assignment copy";
    mAge = liveOrgToCopy.mAge;
    return *this;
}

int LivingOrganism::GetLifespan()
{
    return mAge;
}

void LivingOrganism::SetLifespan(int lifespan)
{
    mAge = lifespan;
}

string LivingOrganism::GetName()
{
    return mName;
}

void LivingOrganism::SetName(string newName)
{
    mName = newName;
}

void LivingOrganism::Breathe()
{
    PRINT_LINE("heee hoooo");
}

void LivingOrganism::TakeDamage()
{
    PRINT_LINE("taken damage");
}
