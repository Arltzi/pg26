using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace a2
{
    internal class Program
    {
        // ENUMS
        enum Actions
        {
            FEED,
            SLEEP,
            PET,
            PLAY,
            TALK
        }

        static void Main(string[] args)
        {

            #region DECLARATIONS

            const int MAX_ACTIONS = 2;
            const int MAX_AGE = 15;

            string catName = "";
            int numberOfActions = 0;
            int age = 0;
            int hunger = 0;
            int happiness = 0;
            int energy = 0;

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

            void StartGame()
            {
                // ask player what their cat's name should be
                // call generate pet
                // print
            }
            void GeneratePet(string name)
            {
                numberOfActions = 0;
                hunger = 10;
                happiness = 10;
                energy = 10;
                age = 0;
            }

            void AskAction()
            {

            }

            void DoAction()
            {

            }

            void Feed()
            {

            }

            void Sleep()
            {

            }

            void Pet()
            {

            }

            void Play()
            {

            }

            void Talk()
            {

            }

            void PrintStatus()
            {

            }

            #endregion

            #region GAME LOOP

            #endregion

        }
    }
}
