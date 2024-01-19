using System;
using System.Linq;

namespace c_sharp_t1_c1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            int myInt2 = 25;
            bool myBool = true;

            Console.WriteLine("Hello World!");
            Console.WriteLine(myInt);
            Console.WriteLine(myBool + "\n");
            Console.WriteLine("My integer is {0}", myInt);
            Console.WriteLine("My integers are {0} and {1}", myInt, myInt2);
            Console.WriteLine("{0} {1} {0} {1}", myBool, myInt);
            Console.WriteLine("Is {0} bigger than {1}? {2} \n", myInt2, myInt, myBool);

            int int1 = 2, int2 = 3;

            Console.WriteLine(int2 += int1 * int2);

            int maxArgs = 16;
            string holder = "";

            for (int i = 0; i < maxArgs; i++)
            {
                holder += "{" + Convert.ToString(i) + "}";
            }

            Console.WriteLine(holder);

            int testing = int.Parse(Console.ReadLine());

            Console.ReadLine(); // for console readability
        }
    }
}

/* NOTES:
 * chars use single quotes, strings use double quotes
 * can composite format in variable assignments
 * can composite format as an extra parameter in a function?? cool
 */ 
