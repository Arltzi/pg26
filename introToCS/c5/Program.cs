using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c5;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Pet Woofers = new Pet("Woofers", 0.5f, 0.0f, 0.2f, 1.0f);

            Woofers.Eat(2);
            Console.WriteLine(Woofers.hunger);

        //    float number1;
        //    float number2;

        //    string operation;

        //firstQuestionReturn:
        //    Console.WriteLine("Enter the first number:");
        //    try
        //    {
        //        number1 = float.Parse(Console.ReadLine());
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        goto firstQuestionReturn;
        //    }

        //secondQuestionReturn:
        //    Console.WriteLine("Enter the second number:");
        //    try
        //    {
        //        number2 = float.Parse(Console.ReadLine());
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Please enter a valid second number");
        //        goto secondQuestionReturn;
        //    }

        //    Console.WriteLine("Please enter the desired operation:");
        //operatorQuestionReturn:
        //    operation = Console.ReadLine();

        //    if (operation == "+")
        //    {
        //        Console.WriteLine("The result is {0}", number1 + number2);
        //    }
        //    else if (operation == "-")
        //    {
        //        Console.WriteLine("The result is {0}", number1 - number2);
        //    }
        //    else if (operation == "*")
        //    {
        //        Console.WriteLine("The result is {0}", number1 * number2);
        //    }
        //    else if (operation == "/" && number2 != 0)
        //    {
        //        Console.WriteLine("The result is {0}", number1 / number2);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid operation, please enter a valid operation");
        //        goto operatorQuestionReturn;
        //    }

        //    Console.ReadLine();
        }
    }
}