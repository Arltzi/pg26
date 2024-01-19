/**
    VFS Intro to C++
    Purpose: Implements car class for assignment

    @class Intro to Programming in C++
    @version 1.1
*/

#include "Car.h"
#include "Utility.h"

int main()
{
    Car hondaNSX;
    hondaNSX.TurnKeyToStart();
    hondaNSX.ShiftGearUp();
    hondaNSX.AcceleratorPeddleDown(32.0);
    hondaNSX.ShiftGearUp();
    hondaNSX.AcceleratorPeddleDown(40.0);
    hondaNSX.ShiftGearUp();
    hondaNSX.AcceleratorPeddleDown(60.0);
    hondaNSX.HornPressed();
    hondaNSX.HornPressed();
    hondaNSX.HornPressed();
    hondaNSX.HornReleased();
    PRINT_LINE("bmw driver wouldn't get out the way");
    hondaNSX.ShiftGearDown();
    //hondaNSX.AcceleratorPeddleReleased();
    hondaNSX.ShiftGearDown();
    //hondaNSX.AcceleratorPeddleReleased();
    hondaNSX.ShiftGearDown();
    //dhondaNSX.AcceleratorPeddleReleased();
}

Car::Car() 
{
    mRunning = false;
    mGear = 0; // 0 is neutral, -1 is reverse
    mSpeed = 0;
    mNoise = false;
    mMaxGear = 6;
}

Car::~Car()
{

}

void Car::TurnKeyToStart()
{
    PRINT_LINE("turning the car on, very very happy");
    mRunning = true;
}

void Car::TurnKeyToStop()
{
    PRINT_LINE("turning the car off, very sad");
    mRunning = false;
}

void Car::ShiftGearUp()
{
    if (mGear < mMaxGear)
    {
        PRINT_LINE("upshift to gear " + mGear);
        ++mGear;
    }
    else
    {
        PRINT_LINE("can't upshift past gear " + mMaxGear);
    }
}

void Car::ShiftGearDown()
{
    if (mGear > 1) 
    {
        --mGear;
        PRINT_LINE("downshift to gear " + mGear);
    }
    else if(mGear == 1)
    {
        --mGear;
        PRINT_LINE("shifting into neutral");
    }
    else if(mGear == 0 && mSpeed >= 5)
    {
        --mGear;
        PRINT_LINE("you blew the transmission :(");
    }
    else
    {
        --mGear;
        PRINT_LINE("putting it in reverse");
    }
}

void Car::AcceleratorPeddleDown(float speedDelta)
{
    if (mGear > 0)
    {
        PRINT_LINE("Increasing speed by " << speedDelta << " km/h");
        PRINT_LINE("vrooooOOOOOOMM");
        mSpeed += speedDelta;
    }
    else if (mGear = 0)
    {
        PRINT_LINE("lots of noise but nothing to show");
    }
    else
    {
        PRINT_LINE("Going in reverse at ");
    }
}

void Car::AcceleratorPeddleReleased(float speedDelta)
{
    PRINT_LINE("Decreasing speed by " << speedDelta << " km/h");
    PRINT_LINE("bzzz");
    mSpeed -= speedDelta;
}

void Car::HornPressed()
{
    PRINT_LINE("HOOOOOOONK");
    mNoise = true;
}

void Car::HornReleased()
{
    PRINT_LINE("nothing but the roar of that sweet vtec v6");
    mNoise = false;
}