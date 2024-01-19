using System;

namespace itcs_t1_c3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ask user for number of students, n
            Console.WriteLine("How many students would you like to register? Please enter a positive integer.");
            string[] aStudents = new string[int.Parse(Console.ReadLine())];

            // ask user for name of student n times
            for (int i = 0; i < aStudents.Length; i++)
            {
                Console.WriteLine("enter the name of student #{0}", i + 1);
                aStudents[i] = Console.ReadLine();
            }

            // print to console each element in the array
            for (int i = 0; i < aStudents.Length; i++)
            {
                Console.WriteLine(aStudents[i]);
            }

            // reverse the array
            string[] aReverseStudents = new string[aStudents.Length];
            for (int i = aStudents.Length; i > 0; i--)
            {
                aReverseStudents[aStudents.Length - i] = aStudents[i - 1];
            }

            // print to console each element in the reversed array 
            for (int i = 0; i < aReverseStudents.Length; i++)
            {
                Console.WriteLine(aReverseStudents[i]);
            }

        }
    }
}
