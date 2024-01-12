using System;

namespace intro_to_c_sharp_t1_c1_a1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * assign 2 lines of user input to int1 and int2
             * write to console the expression "int1 + int2 = int3" using the 2 ints and composite formatting
             */
            int myInt1, myInt2;
            myInt1 = int.Parse(Console.ReadLine());
            myInt2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", myInt1, myInt2, myInt1 + myInt2);

            Console.ReadLine();
        }
    }
}
