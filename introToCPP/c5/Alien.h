#pragma once
#include "LivingOrganism.h"

class Alien :
    public LivingOrganism
{

public:
    Alien() = delete;
    ~Alien();

    Alien(string name, int age, Colour bloodColor);
    Alien(string name, int age, Colour bloodColor, float digestTime);

    Alien(const Alien& alienToCopy);
    Alien& operator=(const Alien& alienToCopy);

    Colour GetBloodColor();
    void SetBloodColor(Colour newBloodColour);

    float GetTimeToDigest();
    void SetTimeToDigest(float newTimeToDigest);

    virtual void Breathe() override;
    
private:
    Colour mBloodColour;
    float mTimeToDigest;
};

