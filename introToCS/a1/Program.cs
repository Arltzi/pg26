using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace a1
{
    internal class Program
    {

        static Random rand = new Random(); // random singleton, i know its not proper implementation but it's usable in this structure, and i prefer accessing random like this.
        static void Main(string[] args)
        {

            // DECLARATIONS
            int money = 200;
            int betType = 0;
            int betValue = 0;
            string[] betNames = {
                "big",
                "small",
                "odd",
                "even",
                "all 1s",
                "all 2s",
                "all 3s",
                "all 4s",
                "all 5s",
                "all 6s",
                "double 1s",
                "double 2s",
                "double 3s",
                "double 4s",
                "double 5s",
                "double 6s",
                "4 or 17",
                "5 or 16",
                "6 or 15",
                "7 or 14",
                "8 or 13",
                "9 or 12",
                "10 or 11",

            };

            string introText = 
                "I am a traveller from an antique land,  \n" +
                "Who sees three calm and perfect dice of stone \n" +
                "Sat in the desert. . . . Near them, on the sand, \n" +
                "Half sunk a shattered visage lies, whose frown, \n" +
                "And wrinkled lip, and sneer of cold command, \n" +
                "Tell that its sculptor well those passions read \n" +
                "Which yet survive, stamped on these lifeless things, \n" +
                "The hand that mocked them, and the heart that fed; \n" +
                "And on the pedestal, these words appear: \n" +
                "My name is Ozymandias, King of Kings; \n" +
                "Look on my Dice, ye Mighty, and gamble! \n" +
                "A table beside remains. Atop the flatness \n" +
                "Of that colossal surface, glistening coins sit, \n" +
                "Lone and still, ready to place on fortune's shoulders. \n" +
                "\n" +
                "Modified from Percy Blysse Shelley's poem, 'Ozymandias' \n \n"
                ;

            string betTable =
                "========================================================================================== \n" +
                "One-one bets   Specific Triples    Specific Doubles    Three Dice Total    Other \n" +
                "1. Big         5.  All 1s          11. Double 1s       17.  4 or 17        24. Any triples \n" +
                "2. Small       6.  All 2s          12. Double 2s       18.  5 or 16 \n" +
                "3. Odd         7.  All 3s          13. Double 3s       19.  6 or 15 \n" +
                "4. Even        8.  All 4s          14. Double 4s       20.  7 or 14 \n" +
                "               9.  All 5s          15. Double 5s       21.  8 or 13 \n" +
                "               10. All 6s          16. Double 6s       22.  9 or 12 \n" +
                "                                                       23. 10 or 11 \n" +
                "========================================================================================== \n";


            // FUNCTIONS

            //DONE
            // just a fancy Console.Write function that changes the colour of the text mid sentence.
            // Wrote this late and didn't want to put the work in to adapt every sentence in the game to use it
            void OzyAsksGamble()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ozymandias's shattered visage croaks: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("'Speak your gamble, traveller. Your {0} coins may stack to the heavens, or sink into the sand. Only fate shall decide.' \n", money);
            }

            //DONE
            // simply reads user input, throws errors if invalid input
            void AskBetType()
            {
                try
                {
                    betType = int.Parse(Console.ReadLine());
                }
                catch(Exception)
                {
                    throw new Exception("Ozymandias bellows: 'Bah! Waste not Ozymandias's time, infinite as it may be! Speak yourself clearly.'");
                }
                if(betType < 1 || betType > 23)
                {
                    throw new Exception("Ozymandias frowns and says: 'You speak lies traveller - nonsensicals. Don't fight, recuse yourself to fate.'");
                }
            }

            //DONE
            // asks user to input int, throws eror if wrong type or int is not in usable range (1 to current money inclusive)
            void AskBetValue()
            {
                Console.WriteLine("Ozymandias: 'And how much of your ill-gotten wealth shall you toss to Fortune now?'");
                try
                {
                    betValue = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    throw new Exception("Ozymandias bellows: 'Bah! Waste not Ozymandias's time, infinite as it may be! Speak yourself clearly.'");
                }
                if(betValue < 0 || betValue > money)
                {
                    throw new Exception("Ozymandias smirks: 'The unyielding desert misleads you as to the quantity of your material wealth. Look again.'");
                }
            }

            //DONE
            // when a bet is won, call this to update money and write some flavour text informing player of how much they won and current money
            void WinBet(int winnings)
            {
                money += winnings;
                Console.WriteLine("Ozymandias's eyes glisten as he says: 'Fate smiles upon thee. Your pile of golden greed grows by {0} to {1}' \n", winnings, money);
            }

            //DONE
            // when a bet is lost, call this to update money and write some flavour text informing players of how much they lost and current money
            void LoseBet()
            {
                money -= betValue;
                Console.WriteLine("Ozymandias speaks: 'Traveller, you let {0} of my coins sink to the sand, never to rise again. Spare the {1} you have from the same final destination'", betValue, money);
            }

            //DONE
            // generates three random numbers between 0 and 6, sums them, prints text informing the player of the value of each roll, and the sum
            // then handles how to calculate if the player wins or loses, and calls winbet or losebet accordingly. handled in a large switch statement
            void RollThreeDice()
            {
                int roll1 = rand.Next(0, 6);
                int roll2 = rand.Next(0, 6);
                int roll3 = rand.Next(0, 6);
                int sum = roll1 + roll2 + roll3;
                Console.WriteLine(
                    "As you roll Ozymandias's stone dice, a vulture circles overhead. Perhaps it is lady luck watching this encounter from afar. \n" +
                    "========== \n" +
                    "Dice 1: " + roll1 + "\n" +
                    "Dice 2: " + roll2 + "\n" +
                    "Dice 3: " + roll3 + "\n" +
                    "\n" +
                    "Sum: " + sum + "\n" +
                    "=========="
                    );
                switch (betType)
                {
                    case 1:
                        if(11 <= sum && sum <= 17){
                            WinBet(betValue);
                        }
                        else{
                            LoseBet();
                        }
                        break;
                    case 2:
                        if (4 <= sum && sum <= 10)
                        {
                            WinBet(betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 3:
                        if (betValue % 2 == 1)
                        {
                            WinBet(betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 4:
                        if (betValue % 2 == 0)
                        {
                            WinBet(betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 5:
                        if (roll1 == 1 && roll2 == 1 && roll3 == 1)
                        {
                            WinBet(180 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 6:
                        if (roll1 == 2 && roll2 == 2 && roll3 == 2)
                        {
                            WinBet(180 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 7:
                        if (roll1 == 3 && roll2 == 3 && roll3 == 3)
                        {
                            WinBet(180 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 8:
                        if (roll1 == 4 && roll2 == 4 && roll3 == 4)
                        {
                            WinBet(180 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 9:
                        if (roll1 == 5 && roll2 == 5 && roll3 == 5)
                        {
                            WinBet(180 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 10:
                        if (roll1 == 6 && roll2 == 6 && roll3 == 6)
                        {
                            WinBet(180 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 11:
                        {
                            HashSet<int> rolls = new HashSet<int>();
                            rolls.Add(roll1);
                            rolls.Add(roll2);
                            rolls.Add(roll3);
                            if (rolls.Count == 2 && rolls.Contains(1))
                            {
                                WinBet(10 * betValue);
                            }
                            else
                            {
                                LoseBet();
                            }
                            break;
                        }
                    case 12:
                        {
                            HashSet<int> rolls = new HashSet<int>();
                            rolls.Add(roll1);
                            rolls.Add(roll2);
                            rolls.Add(roll3);
                            if (rolls.Count == 2 && rolls.Contains(2))
                            {
                                WinBet(10 * betValue);
                            }
                            else
                            {
                                LoseBet();
                            }
                            break;
                        }
                    case 13:
                        {
                            HashSet<int> rolls = new HashSet<int>();
                            rolls.Add(roll1);
                            rolls.Add(roll2);
                            rolls.Add(roll3);
                            if (rolls.Count == 2 && rolls.Contains(3))
                            {
                                WinBet(10 * betValue);
                            }
                            else
                            {
                                LoseBet();
                            }
                            break;
                        }
                    case 14:
                        {
                            HashSet<int> rolls = new HashSet<int>();
                            rolls.Add(roll1);
                            rolls.Add(roll2);
                            rolls.Add(roll3);
                            if (rolls.Count == 2 && rolls.Contains(4))
                            {
                                WinBet(10 * betValue);
                            }
                            else
                            {
                                LoseBet();
                            }
                            break;
                        }
                    case 15:
                        {
                            HashSet<int> rolls = new HashSet<int>();
                            rolls.Add(roll1);
                            rolls.Add(roll2);
                            rolls.Add(roll3);
                            if (rolls.Count == 2 && rolls.Contains(5))
                            {
                                WinBet(10 * betValue);
                            }
                            else
                            {
                                LoseBet();
                            }
                            break;
                        }
                    case 16:
                        {
                        HashSet<int> rolls = new HashSet<int>();
                        rolls.Add(roll1);
                        rolls.Add(roll2);
                        rolls.Add(roll3);
                        if (rolls.Count == 2 && rolls.Contains(6))
                        {
                            WinBet(10 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                        }
                    case 17:
                        if (sum == 4 || sum == 17)
                        {
                            WinBet(60 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 18:
                        if (sum == 5 || sum == 16)
                        {
                            WinBet(30 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 19:
                        if (sum == 6 || sum == 15)
                        {
                            WinBet(18 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 20:
                        if (sum == 7 || sum == 14)
                        {
                            WinBet(12 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 21:
                        if (sum == 8 || sum == 13)
                        {
                            WinBet(8 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 22:
                        if (sum == 9 || sum == 12)
                        {
                            WinBet(7 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 23:
                        if (sum == 10 || sum == 11)
                        {
                            WinBet(6 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    case 24:
                    {
                        HashSet<int> rolls = new HashSet<int>();
                        rolls.Add(roll1);
                        rolls.Add(roll2);
                        rolls.Add(roll3);
                        if (rolls.Count == 1)
                        {
                            WinBet(30 * betValue);
                        }
                        else
                        {
                            LoseBet();
                        }
                        break;
                    }
                }
            }

            //DONE
            // waits for any user input to continue the program
            void ConsoleWait(string message)
            {
                Console.WriteLine(message);
                Console.ReadKey();
            }

            //DONE
            // checks if game is over if player has no money or too much, if yes, call askifplayagain(), if not call consolewait() and start betting loop again
            void CheckIfGameOver()
            {
                if(money == 0)
                {
                    Console.WriteLine("Ozymandias disappointedly exclaims: 'Like all the rest, like me, you let yourself drown in the desert'");
                    AskIfPlayAgain();
                }
                else if(money >= 100000)
                {
                    Console.WriteLine("Ozymandias excitedly exclaims: 'You have risen! Risen higher than the sky and life itself! It can be done!!! Traveller, fate has let you win!'");
                    AskIfPlayAgain();
                }
                else
                {
                    ConsoleWait("Hit any key to bet again.");
                }

            }

            //DONE
            // asks player if theyd like to play again after winning or losing
            // Y plays again, n or N does not
            // any other input just starts the function again, and asks again
            void AskIfPlayAgain()
            {
                bool askAgain = true;
                while(askAgain)
                { 
                    Console.WriteLine("Ozymandias stares into your soul and asks: 'Traveller, fate has judged once, she does not like to judge again, but for you she shall. Will you let her?' Y/n?");
                    string ans = Console.ReadLine();
                    if(ans == "n" || ans == "N")
                    {
                        Environment.Exit(0);
                    }
                    else if(ans == "Y")
                    {
                        askAgain = false;
                    }
                }
            }

            // GAME LOOP
            // intro. just sets the text colour and writes the introductory poem to the screen
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(introText);
            ConsoleWait("Hit any key to continue.");
            // loop
            while (true)
            {
                // clear intro flavour text, or old loop text, and start
                Console.Clear();
                Console.Write(betTable);
                OzyAsksGamble();

                // asks the player what bet type they want
                // asks again if they gave an invalid answer, continues if valid
                bool betTypeSucceeded = false;
                while(!betTypeSucceeded)
                {
                    try
                    {
                        AskBetType();
                        betTypeSucceeded = true;
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }

                // asks player how much they want to bet
                // asks again if invalid answer, continues if valid
                bool betValueSucceded = false;
                while (!betValueSucceded)
                {
                    try
                    {
                        AskBetValue();
                        betValueSucceded = true;
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }

                // calculate if player wins or loses the bet, adjusts money accordingly
                RollThreeDice();

                // check if player won or lost the game, if yes, asks if they want to play again, if not, asks for any input before starting the loop again
                CheckIfGameOver();
            }
        }
    }
}
