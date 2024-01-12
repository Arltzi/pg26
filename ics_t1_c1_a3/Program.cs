using System;

namespace ic__t1_c1_a2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a celsius temperature as an integer");
            int celsius = int.Parse(Console.ReadLine()); // get user input and convert to int
            float fahrenheit = (celsius) * (9f/5f) + 32; // calculate fahrenheit
            Console.WriteLine("{0} in celsius is {1} in fahrenheit", celsius, fahrenheit); //output with nice formatting
            
            Console.ReadLine();
        }
    }
}
