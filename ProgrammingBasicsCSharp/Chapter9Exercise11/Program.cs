/*
   <summary>    
   TITLE             Algebraic Problem Solver    Chapter9Exercise11 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a program with interface that lets you choose whether to:
                      - reverses the digits of a mumber.
                      - calculates the arithmetic mean of set of numbers.
                      - finds the root of the linear equation a * x + b = 0.

                      Check input validity:
                      - integer must be positive.
                      - the set must be non - empty.
                      - a != 0 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>05.04.2016</datecreated>
*/
using System;

namespace Chapter9Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface();
        }
        //----------------------------------------------------------------------------------------------------------

        /*
            Method: LinearEquationRoot();

            It returns the root of the linear
            equation a*x + b = 0.

            Checks for input validity:
            - number of input tokens
            - type of input tokens
            - first token  != 0
        */
        static void LinearEquationRoot()
        {
            while (true)
            {
                Console.WriteLine("Type the coefficients 'a' and 'b' on a single line separated by whitespace:");
                string[] tokens = Console.ReadLine().Split();

                int a = 0, b = 0;
                if (tokens.Length == 2 && int.TryParse(tokens[0], out a) && int.TryParse(tokens[1], out b))
                {
                    if (a != 0)
                    {
                        Console.WriteLine("x = {0, 2}", -b / (double)a);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("The coefficient 'a' must be != 0");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input format!");
                }

            }
        }
        //----------------------------------------------------------------------------------------------------------

        /*
            Method: ArithmeticMean();

            It prints the arithmetic mean
            of a set of numbers.

            Checks for input validity:
            - number of elements in the set
            - input format
        */
        static void ArithmeticMean()
        {
            while (true)
            {
                Console.WriteLine("Type a set of numbers on a single line separated by whitespace:");
                string[] tokens = Console.ReadLine().Split();

                int CarriageReturn = 0;
                if (tokens.Length == 1 && !int.TryParse(tokens[0], out CarriageReturn))
                {
                    Console.WriteLine("Set must not be empty!");
                }
                else
                {
                    int[] numbers = new int[tokens.Length];
                    int sum = 0;

                    int length = tokens.Length;
                    for (int i = 0; i < length; i++)
                    {
                        if (int.TryParse(tokens[i], out numbers[i]))
                        {
                            sum += numbers[i];
                        }
                        else
                        {
                            Console.WriteLine("Wrong input format!");
                            break;
                        }
                    }
                    Console.WriteLine("Arithmetic mean = {0}", sum / (double)length);
                    return;
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------

        /*
            Method: ReverseDigits();

            It prints an input integer
            digits in reverse order.

            Checks for input validity:
            - sign of the input integer
            - input format
        */
        static void ReverseDigits()
        {
            while (true)
            {
                Console.WriteLine("Type a positive, multidigit integer:");
                string input = Console.ReadLine();

                int number = 0;
                if (int.TryParse(input, out number))
                {
                    if (number > 0)
                    {
                        while (number != 0)
                        {
                            Console.Write(number % 10);
                            number /= 10;
                        }
                        Console.WriteLine();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Number must be positive!");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input format!");
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------

        /*
            Method: Interface()

            It prompts the user to select one of the 
            listed choices. It calls the functions
            needed for calculation. 
        */
        static void Interface()
        {
            Console.WriteLine("Type an integer value matching your choice; 'q' to exit.");

            string prompt = "\n1. Reverse the digits of a number\n2. Calculate the arithmetic mean.\n3. Solve a*x + b = 0.";
            string sentinel = "q";

            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (input == sentinel)
                {
                    break;
                }

                int select = 0;
                if (int.TryParse(input, out select))
                {
                    switch (select)
                    {
                        case 1: ReverseDigits(); break;
                        case 2: ArithmeticMean(); break;
                        case 3: LinearEquationRoot(); break;
                        default: Console.WriteLine("Select a number from 1 to 3."); break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input format, try again!");
                }
            }
        }
    }
}
