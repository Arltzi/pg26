using System;

namespace ic__t1_c1_a4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input 4 integers to be reversed, no spaces:");
            //int numberToReverse = int.Parse(Console.ReadLine());
            //int digit4 = numberToReverse % 10;
            //int digit3 = (numberToReverse - digit4) % 100;
            //int digit2 = (numberToReverse - digit3 - digit4) % 1000;
            //int digit1 = numberToReverse - digit2 - digit3 - digit4;
            //Console.WriteLine("Your number reversed is; {0}{1}{2}{3}", digit4, digit3 / 10, digit2 / 100, digit1 / 1000);
            //Console.ReadLine();

            //Console.WriteLine("Input 4 integers to be reversed, no spaces:");
            //int numberToReverse = int.Parse(Console.ReadLine());
            //int digit4 = numberToReverse % 10;
            //int digit3 = numberToReverse % 100;
            //int digit2 = numberToReverse % 1000;
            //Console.WriteLine("Your number reversed is; {0}{1}{2}{3}", digit4, digit3 / 10, digit2 / 100, numberToReverse / 1000);
            //Console.ReadLine();

            Console.WriteLine("Input 4 integers to be reversed, no spaces:");
            int numberToReverse = int.Parse(Console.ReadLine());
            int digit4 = numberToReverse % 10;
            int digit3 = numberToReverse % 100 / 10;
            int digit2 = numberToReverse % 1000 / 100;
            int digit1 = numberToReverse / 1000;
            int finalAnswer = digit4 * 1000 + digit3 * 100 + digit2 * 10 + digit1;
            Console.WriteLine("Your number reversed is; {0}", finalAnswer);
            Console.ReadLine();
        }
    }
}
