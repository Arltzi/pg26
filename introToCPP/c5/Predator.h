#pragma once
#include "Alien.h"
class Predator :
    public LivingOrganism
{
public:
    Predator() = delete;
    ~Predator();

    // paramaterized constructors
    Predator(string name, int age, bool isInvis);
    Predator(string name, int age, bool isInvis, float topSpeed);

    // copy constructors
    Predator(const Predator& predatorToCopy);
    Predator& operator=(const Predator& predatorToCopy);

    // getters & setters
    bool GetIsInvis();
    void SetIsInvis(bool newInvisState);

    float GetTopSpeed();
    void SetTopSpeed(float newTopSpeed);

    virtual void Breathe() override;

    virtual void TakeDamage() override;

private:
    bool mIsInvis;
    float mTopSpeed;

};

