using System;

namespace t1_c4
{
    internal class Program
    {
        enum ITestEnum
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,

        };

        static void Main(string[] args)
        {
            /*Console.WriteLine("Which day of the week would you like to schedule your prostate exam? \n" +
                "Enter 1 for monday, 2 for tuesday [...] 7 for sunday");
            ITestEnum scheduledDate;
            scheduledDate = (ITestEnum)int.Parse(Console.ReadLine());
            Console.WriteLine("To confirm, you'd like to schedule your prostate exam for " + scheduledDate);*/

            // AskAndCompare();

            /*int[] intArray;
            intArray = new int[] {0,1,2,3,4,5,6,7,8,9};

            Console.WriteLine(BiggestIntInArray(intArray));

            Console.WriteLine(SmallestIntInArray(intArray));

            Console.WriteLine("Enter two numbers, new line separated for power function");
            int baseNum = int.Parse(Console.ReadLine());
            int exponentNum = int.Parse(Console.ReadLine());
            Console.WriteLine(PowerFunc(baseNum, exponentNum));*/


        }

        static int BiggestInt(int integerOne, int integerTwo)
        {
            return integerTwo > integerOne ? integerTwo : integerOne;
        }

        static void PrintBiggestInt(int inputInteger)
        {
            Console.WriteLine("{0} is the bigger number.", inputInteger);
        }

        static void AskAndCompare()
        {
            int integerOne = AskForNumber();
            int integerTwo = AskForNumber();
            PrintBiggestInt(BiggestInt(integerOne, integerTwo));
        }
           
        static int AskForNumber()
        {
            Console.WriteLine("What is the first number you'd like to compare?");
            return int.Parse(Console.ReadLine());
        }

        static int BiggestIntInArray(int[] intArray)
        {
            int biggestNum = int.MinValue;
            foreach(int iterator in intArray)
            {
                biggestNum = iterator > biggestNum ? iterator : biggestNum;
            }
            return biggestNum;
        }

        static int SmallestIntInArray(int[] intArray)
        {
            int smallestNum = int.MaxValue;
            foreach (int iterator in intArray)
            {
                smallestNum = iterator < smallestNum ? iterator : smallestNum;
            }
            return smallestNum;
        }

        static float PowerFunc(int baseNum, int exponentNum)
        {
            int powerResult = 1;
            if(exponentNum >= 0)
            {
                for (int i = 0; i < exponentNum; i++)
                {
                    powerResult *= baseNum;
                };
                return powerResult;
            }
            else
            {
                for (int i = 0; i > exponentNum; i--)
                {
                    powerResult *= baseNum;
                };
                return (float)(1.0f / powerResult);
            }
        }
    }
}
