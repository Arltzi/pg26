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
    // print instructions to user
    PRINT_LINE("You take the key to your red Honda NSX out of your pocket, unlock your car, and - closing the door behind you - get in.");
    PRINT_LINE("Here's how you use your car, just in case you've forgotten, or don't have your license: \n"
                "s - starts and stops the car \n"
                "e - shifts up a gear, if possible \n"
                "d - shifts down a gear, if possible \n"
                "r - put your foot on the accelerator \n"
                "f - put your foot on the brake\n"
                "h - start and stop honking \n \n"

                "NOTES: Gear 1-6 is forward, gear 0 is neutral, gear -1 is reverse"
    );

    // instantiate car
    Car hondaNSX;

    // single label for goto, i could wrap the whole gameplay loop in another loop, but since im doing this once, this is easier
    gameStart:
    // loop that gets player to start car. basically any input other than 's' tries again, 's' starts the car and ends the loop
    while (!hondaNSX.IsRunning())
    {
        PRINT_LINE("Please start the car to begin!");

        char cur;
        READ_USER_INPUT(cur);

        if (cur == 's')
        {
            hondaNSX.TurnKeyToStart();
        }
        else
        {
            PRINT_LINE("Rohit, this is here to show you that I am indeed sanitizing my inputs, try to start the car again >:(");
        }
    }

    while (hondaNSX.IsRunning())
    {
        PRINT_LINE("Time to do something!");

        // read user input and call a function to respond, more detailed explanations when the function name isn't enough
        char cur;
        READ_USER_INPUT(cur);

        switch (cur)
        {
        case 's':
            hondaNSX.TurnKeyToStop();
            // without this goto, the game would instantly end instead of prompting you to start the car
            goto gameStart;
            break;
        case 'e':
            hondaNSX.ShiftGearUp();
            break;
        case 'd':
            hondaNSX.ShiftGearDown();
            break;
        case 'r':
        {
            // ask for speed to accelerate by and capture user input, check if valid, break if invalid
            // call accelerator function if input is valid
            PRINT_LINE("how much would you like to accelerate by? please type a positive float value");

            string userInput;
            float accelAmount = 0;
            READ_USER_INPUT(userInput);

            // check if input is actually a float, break if not
            try
            {
                accelAmount = stof(userInput);
            }
            catch (invalid_argument)
            {
                PRINT_LINE("Rohit!!!! i even told you what to type!!");
                break;
            }

            // check if input is positive, continue if positive, break if negative
            if (accelAmount < 0) {
                PRINT_LINE("Rohit!!!! i even told you what to type!!");
                break;
            }

            // calling accelerator function
            hondaNSX.AcceleratorPeddleDown(accelAmount);
            break;
        }
        case 'f':
        {
            // ask for speed to deccelerate by and capture user input, check if valid, break if invalid
            // call deccelerator function if input is valid
            PRINT_LINE("how much would you like to deccelerate by? please type a positive float value");

            string userInput;
            float accelAmount = 0;
            READ_USER_INPUT(userInput);

            // check if input is actually a float, break if not
            try
            {
                accelAmount = stof(userInput);
            }
            catch (invalid_argument)
            {
                PRINT_LINE("Rohit!!!! i even told you what to type!!");
                break;
            }

            // check if input is positive, continue if positive, break if negative
            if (accelAmount < 0) {
                PRINT_LINE("Rohit!!!! i even told you what to type!!");
                break;
            }

            // call accelerator function
            hondaNSX.AcceleratorPeddleReleased(accelAmount);
            break;
        }
        case 'h':
            // if honking, stop, if not honking, start
            if (!hondaNSX.IsHonking())
            {
                hondaNSX.HornPressed();
            }
            else
            {
                hondaNSX.HornReleased();
            }
            break;
        }

    }
    //hondaNSX.TurnKeyToStart();
    //hondaNSX.ShiftGearUp();
    //hondaNSX.AcceleratorPeddleDown(32.0);
    //hondaNSX.ShiftGearUp();
    //hondaNSX.AcceleratorPeddleDown(40.0);
    //hondaNSX.ShiftGearUp();
    //hondaNSX.AcceleratorPeddleDown(60.0);
    //hondaNSX.HornPressed();
    //hondaNSX.HornPressed();
    //hondaNSX.HornPressed();
    //hondaNSX.HornReleased();
    //PRINT_LINE("bmw driver wouldn't get out the way");
    //hondaNSX.ShiftGearDown();
    //hondaNSX.AcceleratorPeddleReleased();
    //hondaNSX.ShiftGearDown();
    //hondaNSX.AcceleratorPeddleReleased();
    //hondaNSX.ShiftGearDown();
    //dhondaNSX.AcceleratorPeddleReleased();
}

// FUNCTIONS

// constructor, nothing unusual 
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

// accessors
// my own added get functions for some bools
bool Car::IsRunning()
{
    return mRunning;
}
bool Car::IsHonking()
{
    return mNoise;
}
float Car::GetSpeed()
{
    return mSpeed;
}
int Car::GetGear()
{
    return mGear;
}

// nothing to say
void Car::TurnKeyToStart()
{
    PRINT_LINE("turning the car on, very very happy");
    mRunning = true;
}
 // nothing to say
void Car::TurnKeyToStop()
{
    PRINT_LINE("turning the car off, very sad");
    mRunning = false;
}

// basically just printing different messages for shifting to neutral and reverse
// prevents any shift above 6
// if you're in reverse at speed, shift through neutral to first, this sets speed to 0. 
// youre lucky im not having that behaviour blow up the transmission
void Car::ShiftGearUp()
{
    if (mGear < mMaxGear)
    {
        mGear++;
        PRINT_LINE("upshift to gear " << mGear);
        if (mSpeed <= 0)
        {
            mSpeed = 0;
        }
    }
    else if (mGear == -1)
    {
        PRINT_LINE("shifting into neutral");
        mGear++;
    }
    else
    {
        PRINT_LINE("can't upshift past gear " << mMaxGear);
    }
}

// basically just printing different messages for shifting to neutral and reverse
// prevents any shift below -1 (reverse)
// if you're going forward at speed, shift through neutral to reverse, this sets speed to 0. 
// youre lucky im not having that behaviour blow up the transmission as well
void Car::ShiftGearDown()
{
    if (mGear > 1) 
    {
        mGear--;
        PRINT_LINE("downshift to gear " << mGear);
    }
    else if(mGear == 1)
    {
        mGear--;
        PRINT_LINE("shifting into neutral");
    }
    else if(mGear == 0)
    {
        mGear--;
        PRINT_LINE("putting it in reverse");
        mSpeed = 0;
    }
    else if(mGear == -1)
    {
        PRINT_LINE("you can't shift any lower silly!");
    }
}

// acceleration is limited to 80 km/h in one call, switch statement handles invalid inputs
// acceleration in reverse is unlimited hahahahaha, just leaving that in for fun.
// fun fact: the Rimac nevera has the record for highest speed in reverse at 275.7 km/h... insane 
void Car::AcceleratorPeddleDown(float speedDelta)
{
    if (mGear > 0)
    {
        if (speedDelta > 80)
        {
            mSpeed += 80;
            PRINT_LINE("Can't accelerate by more than 80 km/h at once");
            PRINT_LINE("Increasing speed by " << speedDelta << " km/h to " << mSpeed << " km/h!");
            PRINT_LINE("vrooooOOOOOOMM");
        }
        else
        {
            mSpeed += speedDelta;
            PRINT_LINE("Increasing speed by " << speedDelta << " km/h to " << mSpeed << " km/h!");
            PRINT_LINE("vrooooOOOOOOMM");
        }
    }
    // if in neutral
    else if (mGear == 0)
    {
        PRINT_LINE("Lots of noise but nothing to show. Get into gear!");
    }
    // if in reverse
    else
    {
        mSpeed -= speedDelta;
        PRINT_LINE("Going in reverse at " << -mSpeed << " km/h");
    }
}

// braking
// unusual added if statements are to prevent you from braking so hard you accelerate
void Car::AcceleratorPeddleReleased(float speedDelta)
{
    if (mSpeed >= 0)
    {
        mSpeed -= speedDelta;
        PRINT_LINE("Decreasing speed by " << speedDelta << " km/h to " << mSpeed << " km/h!");
        if (mSpeed < 0)
        {
            mSpeed = 0;
        }
    }
    if (mSpeed < 0)
    {
        mSpeed += speedDelta;
        PRINT_LINE("Decreasing speed by " << speedDelta << " km/h to " << -mSpeed << " km/h!");
        if (mSpeed > 0)
        {
            mSpeed = 0;
        }
    }
}

// not much to say
void Car::HornPressed()
{
    PRINT_LINE("HOOOOOOONK");
    mNoise = true;
}

// not much to say
void Car::HornReleased()
{
    PRINT_LINE("nothing but the roar of that sweet vtec v6");
    mNoise = false;
}