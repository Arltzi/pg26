using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

public class Cat
{
    #region ENUMS

    enum CatStatus
    {
        DEAD,
        HAPPY,
        SAD,
        HUNGRY,
        SLEEPY
    }
    enum CatStats
    {
        AGE,
        SATIETY,
        HAPPINESS,
        ENERGY,
        HYDRATION
    }

    #endregion

    #region DECLARATIONS
    const int MAX_ACTIONS = 2;
    const int MAX_AGE = 15;

    string catName = "";
    int numberOfActions = 0;

    CatStatus catStatus = CatStatus.HAPPY;
    Dictionary<CatStats, int> catStats = new Dictionary<CatStats, int>()
    {
        {CatStats.AGE, 0},
        {CatStats.SATIETY, 10},
        {CatStats.HAPPINESS, 10},
        {CatStats.ENERGY, 10},
        {CatStats.HYDRATION, 10},
    };

    string catFace = "";

    string deadCat =
    "----------- \n" +
    @"| |\---/| |" + "\n" +
    @"| | x_x | |" + "\n" +
    @"|  \_^_/  |"  + "\n" +
    "----------- \n";

    string happyCat =
    "----------- \n" +
    @"| |\---/| |" + "\n" +
    @"| | ^_^ | |" + "\n" +
    @"|  \_Ɐ_/  |"  + "\n" +
    "----------- \n";

    string sadCat =
    "----------- \n" +
    @"| |\---/| |" + "\n" +
    @"| | ;_; | |" + "\n" +
    @"|  \_n_/  |"  + "\n" +
    "----------- \n";

    string hungryCat =
    "----------- \n" +
    @"| |\---/| |" + "\n" +
    @"| | -_- | |" + "\n" +
    @"|  \_Ɐ_/  |"  + "\n" +
    "----------- \n";

    string sleepyCat =

    "----------- \n" +
    @"| |\---/| |" + "\n" +
    @"| | x_x | |" + "\n" +
    @"|  \_^_/  |"  + "\n" +
    "----------- \n";
    #endregion

    #region FUNCTIONS

    public Cat()
    {
        catName = "defaultName";
        catFace = happyCat;
        string actionList =
            "Type 1 to feed " + catName + ". \n" +
            "Type 2 to hydrate " + catName + ". \n" +
            "Type 3 to let " + catName + " sleep. \n" +
            "Type 4 to pet " + catName + ". \n" +
            "Type 5 to play with " + catName + ". \n"
        ;
    }

    void Feed()
    {
        catStats[CatStats.SATIETY] += 2;
        catStats[CatStats.ENERGY] -= 2;
        catStats[CatStats.HYDRATION] -= 1;
    }

    void Hydrate()
    {
        catStats[CatStats.HYDRATION] += 3;
    }

    void Sleep()
    {
        catStats[CatStats.SATIETY] -= 1;
        catStats[CatStats.HAPPINESS] -= 1;
        catStats[CatStats.ENERGY] += 2;
    }

    void Pet()
    {
        catStats[CatStats.HAPPINESS] += 1;
        catStats[CatStats.SATIETY] -= 1;
    }

    void Play()
    {
        catStats[CatStats.HAPPINESS] += 5;
        catStats[CatStats.SATIETY] -= 1;
        catStats[CatStats.ENERGY] -= 2;
        catStats[CatStats.HYDRATION] -= 2;
    }
    #endregion
}