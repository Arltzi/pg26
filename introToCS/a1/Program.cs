using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace a1
{
    internal class Program
    {
        public static Random rand; // random singleton, i know its not proper implementation but it's usable in this structure, and i prefer accessing random like this.

        static void Main(string[] args)
        {
            // DECLARATIONS
            bool isGameRunning = true;
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
                "========================================================================================== \n" +
                "\n" +
                "You have {0}, what bet would you like to make?";

            // FUNCTIONS

            int AskBetType()
            {
                try
                {
                    betType = int.Parse(Console.ReadLine());
                }
                catch(Exception)
                {
                    throw new Exception("Invalid Bet Type Input");
                }
                if(betType < 1 || betType > 23)
                {
                    throw new Exception("BetType must be between 1 and 23 inclusive");
                }
                return betType;
            }

            void AskBetValue(int betType)
            {
                Console.WriteLine("How much would you like to bet on {0}?", betNames[betType - 1]);
                try
                {
                    betValue = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    throw new Exception("Invalid Bet Value Input");
                }
                if(betValue < 0 || betValue > money)
                {
                    throw new Exception("Invalid Bet Value Input");
                }
            }

            void Win(int winnings)
            {

            }

            void Lose()
            {

            }

            void RollThreeDice()
            {
                int roll1 = rand.Next(0, 6);
                int roll2 = rand.Next(0, 6);
                int roll3 = rand.Next(0, 6);
                int sum = roll1 + roll2 + roll3;
                Console.WriteLine(
                    "========== \n" +
                    "shake shake shake shake shhhh \n" +
                    "Dice 1: {0} \n" +
                    "Dice 2: {1} \n" +
                    "Dice 3: {2} \n" +
                    "\n" +
                    "Sum: {4}" +
                    "==========",
                    roll1, 
                    roll2, 
                    roll3, 
                    sum
                    );
                switch (betType)
                {
                    case 1:
                        if(11 <= sum && sum <= 17){
                            Win(betValue);
                        }
                        else{
                            Lose();
                        }
                        break;
                    case 2:
                        if (4 <= sum && sum <= 10)
                        {
                            Win(betValue);
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case 3:
                        if (betValue % 2 == 1)
                        {
                            Win(betValue);
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case 4:
                        if (betValue % 2 == 0)
                        {
                            Win(betValue);
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case 5:
                        if (roll1 == 1 && roll2 == 1 && roll3 == 1)
                        {
                            Win(180 * betValue);
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case 6:
                        if (roll1 == 2 && roll2 == 2 && roll3 == 2)
                        {
                            Win(180 * betValue);
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case 7:
                        if (roll1 == 3 && roll2 == 3 && roll3 == 3)
                        {
                            Win(180 * betValue);
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case 8:
                        if (roll1 == 4 && roll2 == 4 && roll3 == 4)
                        {
                            Win(180 * betValue);
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case 9:
                        if (roll1 == 5 && roll2 == 5 && roll3 == 5)
                        {
                            Win(180 * betValue);
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case 10:
                        if (roll1 == 6 && roll2 == 6 && roll3 == 6)
                        {
                            Win(180 * betValue);
                        }
                        else
                        {
                            Lose();
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
                                Win(10 * betValue);
                            }
                            else
                            {
                                Lose();
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
                                Win(10 * betValue);
                            }
                            else
                            {
                                Lose();
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
                                Win(10 * betValue);
                            }
                            else
                            {
                                Lose();
                            }
                            break;
                        }
                        break;
                    case 14:
                        {
                            HashSet<int> rolls = new HashSet<int>();
                            rolls.Add(roll1);
                            rolls.Add(roll2);
                            rolls.Add(roll3);
                            if (rolls.Count == 2 && rolls.Contains(4))
                            {
                                Win(10 * betValue);
                            }
                            else
                            {
                                Lose();
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
                                Win(10 * betValue);
                            }
                            else
                            {
                                Lose();
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
                                Win(10 * betValue);
                            }
                            else
                            {
                                Lose();
                            }
                            break;
                        }
                    case 17:
                        if (sum == 4 || sum == 17)
                        {
                            Win(60 * betValue);
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case 18:
                        if (sum == 5 || sum == 16)
                        {
                            Win(30 * betValue);
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case 19:
                        if (sum == 6 || sum == 15)
                        {
                            Win(18 * betValue);
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case 20:
                        if (sum == 7 || sum == 14)
                        {
                            Win(12 * betValue);
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case 21:
                        if (sum == 8 || sum == 13)
                        {
                            Win(8 * betValue);
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case 22:
                        if (sum == 9 || sum == 12)
                        {
                            Win(7 * betValue);
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case 23:
                        if (sum == 10 || sum == 11)
                        {
                            Win(6 * betValue);
                        }
                        else
                        {
                            Lose();
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
                                Win(30 * betValue);
                            }
                            else
                            {
                                Lose();
                            }
                            break;
                        }
                }
            }

            void AskIfAgain()
            {
                Console.WriteLine("Would you like to play again?");
                string ans = Console.ReadLine();
                if(ans == "No")
                {
                    Environment.Exit(0);
                }
            }

            void CheckIfEnd()
            {
                if(money == 0)
                {
                    Console.WriteLine("dang you broke.");
                    AskIfAgain();
                }
                if(money >= 100000)
                {
                    Console.WriteLine("You broke the bank dude");
                    AskIfAgain();
                }
            }

            // GAME LOOP
            while(isGameRunning)
            {
                Console.WriteLine(
                    "Flavour text" +
                    " ");

            }
            return;
        }
    }
}
