/*
   <summary>    
   TITLE              Solve quadratic equation  Chapter5Exercise6.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a program that finds the roots of a
                      quadratic equation. Roots could be: 0, 1 or 2.

                      Code from: Chapter4Exercise9.cs 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>29.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter5Exercise6
    {
        static void Main()
        {
            const int size = 3;
            string[] terms = new string[size] { "quadratic", "linear", "constant" };
            // array storing the three coefficients of the quadratic equations
            double[] coefficients = new double[size];

            // information
            Console.WriteLine("Solve qadratic equations.");

            // read input
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Type the " + terms[i] + " term.");
                string input = Console.ReadLine();

                double term = 0;
                if (double.TryParse(input, out term))
                {
                    coefficients[i] = term;
                }
                else
                {
                    Console.WriteLine("Wrong input format, try again!");
                    // decrement counter to account for the wrong input
                    --i;
                }
            }

            // calculate and print result
            Console.WriteLine("\nThe equation: {0:F2}x^2 + {1:F2}x + {2:F2} = 0, has:", coefficients[0], coefficients[1], coefficients[2]);

            solveQuadratic(coefficients[0], coefficients[1], coefficients[2]);
        }
        //------------------------------------------------------------------------------------------------

        /*
           Method: solveQuadratic()

           Finds the real roots of the quadratic equation
           with coefficients passed as parameters.
       */
        static void solveQuadratic(double quadratic, double linear, double constant)
        {
            double discriminant = linear * linear - (4 * quadratic * constant);

            if (discriminant == 0)
            {
                Console.WriteLine("Single root: {0,10:F2}", (-linear / (2 * quadratic)));
            }
            else if (discriminant > 0)
            {
                Console.WriteLine("First root: {0,10:F2} ", ((-linear + Math.Sqrt(discriminant)) / (2 * quadratic)));
                Console.WriteLine("Second root: {0,9:F2}", ((-linear - Math.Sqrt(discriminant)) / (2 * quadratic)));
            }
            else
            {
                Console.WriteLine("There are no roots!");
            }
        }
    }
}
