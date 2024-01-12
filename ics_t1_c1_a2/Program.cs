using System;

namespace ic__t1_c1_a2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * take user input as string (representing a fahrenheit temperature)
             * convert input to int
             * calculate celsius value
             * log values with some nice formatting
             */
            Console.WriteLine("Please input a fahrenheit temperature as an integer");
            int fahrenheit = int.Parse(Console.ReadLine());
            float celsius = (fahrenheit - 32) * 5f / 9f;
            Console.WriteLine("{0} in fahrenheit is {1} in celsius", fahrenheit, celsius);

            Console.ReadLine();
        }
    }
}
