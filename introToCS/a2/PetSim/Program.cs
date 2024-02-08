using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Cat;

namespace a2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region DECLARATIONS
            bool gameRunning = true;
            Cat cat = new Cat();
            #endregion

            #region FUNCTIONS

            void StartGame()
            {
                // ask player what their cat's name should be
                Console.WriteLine(
                    "On the desert planet Arrakis, where water is scarce and care scarcer, owning a pet is a sign of great wealth.  \n" +
                    "Having made your fortune smuggling the spice Melange, risking your life evading the Harkonnen forces to sell   \n" +
                    "spice to remote Fremen sietches, you'd like to retire beneath the towering walls of The Keep. You've always    \n" +
                    "wanted a cat, and as you walk into the Arrakeen Cat store, the shopkeep smiles and immediately spits on the    \n" +
                    "ground, while a servant boy brings a glass of iced water to your side, both signs of enormous respect. As the  \n" +
                    "shopkeep shows you his wares, a striking silver feline catches your eye. The price of it makes you cringe a    \n" +
                    "bit, even with your enormous wealth, but still on the spot you buy it. On the way back you decide that it's    \n" +
                    "name should be:"
                    );
                // construct cat
                string name = Console.ReadLine();
                cat.catName
                // print flavour text
                Console.WriteLine(
                    "Press any key to continue..."
                );
                Console.ReadKey();
            }

            void PrintStatus()
            {
                // calculate cat status (lowest var if below 8, if all above 7 happy cat)

                // print cat face
                // print all relevant variables, labelled
            }

            void TurnStart()
            {
                // print cat face
                Console.WriteLine(cat.catFace);
                // print action list
                Console.WriteLine(actionList);
                // read user input
                int curAction = 0;
                // call action
                switch(curAction)
                {
                    case 1:
                        Feed();
                        break;
                    case 2:
                        Hydrate();
                        break;
                    case 3:
                        Sleep();
                        break;
                    case 4:
                        Pet();
                        break;
                    case 5:
                        Play();
                        break;
                    default:
                        break;
                }
                // iterate action counter
                // iterate age
                catStats;
                numberOfActions ++;
            }




            #endregion

            #region GAME LOOP

            while(gameRunning){

            }
            #endregion
        }
    }
}
