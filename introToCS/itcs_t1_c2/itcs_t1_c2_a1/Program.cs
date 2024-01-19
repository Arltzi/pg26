using System;
using System.Diagnostics;

namespace itcs_t1_c2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DECLARATIONS
            bool isOperationSuccess = false;

            // contains calculator input, logic, and output
            // escapes if operation successful, repeats if not
            while(!isOperationSuccess)
            {
                // removes needing code to set isOperationSuccess = true within the succesful operations
                // basically assume true until false
                isOperationSuccess = true;

                // DECLARATIONS
                float input1 = 0, input2 = 0;
                float result = 1;
                string operationInput = "";
                // resultType is the name for the result of the operation e.g. sum, difference, product, quotient
                string resultType = "";

                // ask user for input, capture input in earlier declared variables
                // input is: float, string, float, representing a number, an operation, and another number
                Console.WriteLine("Please input a number!");
                input1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Please input an operation!");
                operationInput = Console.ReadLine();
                Console.WriteLine("Please input another number!");
                input2 = float.Parse(Console.ReadLine());

                // check operant type, calculate output, set bool to end or continute while loop
                switch (operationInput)
                {
                    case "+":
                        result = input1 + input2;
                        resultType = "sum";
                        break;
                    case "-":
                        result = input1 - input2;
                        resultType = "difference";
                        break;
                    case "*":
                        result = input1 * input2;
                        resultType = "product";
                        break;
                    case "/":
                        if(input2 != 0)
                        {
                            result = input1 / input2;
                            resultType = "quotient";
                        }
                        else 
                        {
                            Console.WriteLine("ERROR: attempted division by 0");
                            isOperationSuccess = false;
                        }
                        break;
                    case "p":
                        if(input2 >= 0)
                        {
                            for(int i = 0; i < input2; i++)
                            {
                                result *= input1;
                            }
                        }
                        else
                        {
                            for(int i = 0; i > input2; i--)
                            {
                                result *= input1;
                            }
                            result = 1 / result;
                        }
                        resultType = "power";
                        break;

                    default:
                        Console.WriteLine("ERROR: unrecognized operant");
                        isOperationSuccess = false;
                        break;
                }

                // print operation output if valid
                if (isOperationSuccess)
                {
                    Console.WriteLine("The {0} of {1} and {2} is {3}", resultType, input1, input2, result);
                }

                // query if user wants to calculate again, restart loop if yes, quit if no
                Console.WriteLine("Would you like to calculate another numeric operation?");
                if(Console.ReadLine().ToLower() == "no")
                {
                    isOperationSuccess = true;
                }
                else
                {
                    isOperationSuccess = false;
                }

                //if (operationInput == "+")
                //{
                //    Console.WriteLine("The sum of {0} and {1} is {2}", input1, input2, input1 + input2);
                //    successfulOperation = true;
                //}
                //else if (operationInput == "-")
                //{
                //    Console.WriteLine("The difference of {0} and {1} is {2}", input1, input2, input1 - input2);
                //    successfulOperation = true;
                //}
                //else if (operationInput == "*")
                //{
                //    Console.WriteLine("The product of {0} and {1} is {2}", input1, input2, input1 * input2);
                //    successfulOperation = true;
                //}
                //else if (operationInput == "/")
                //{
                //    Console.WriteLine("The quotient of {0} and {1} is {2}", input1, input2, input1 / input2);
                //    successfulOperation = true;
                //}
                //else
                //{
                //    Console.WriteLine("ERROR: unrecognized operant, please try again");
                //    successfulOperation = false;
                //}

                // switch case to handle checking the inputted operation, running the operation, and printing the result
                // if the operation is successful
            }

            Console.WriteLine("Launching a game");
            Process.Start("C:\\Users\\Public\\PublicPrograms\\Steam\\steamapps\\common\\Thronefall\\Thronefall.exe");
        }
    }
}
