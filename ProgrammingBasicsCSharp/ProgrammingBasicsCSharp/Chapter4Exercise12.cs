/*
   <summary>  
   TITLE              First n Fibonacci       Chapter4Exercise12.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Type an upper bound to the interval [1, n].
                      Print all the fibonacci numbers within it on a new line.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter4Exercise12
    {
        static void Main()
        {
            // information
            Console.WriteLine("Find first n Fibonacci numbers.");

            // select the number of integers to sum
            string input1 = string.Empty;
            int lowerBound = 1;
            int upperBound = 0;
            do
            {
                Console.WriteLine("How many Fibonacci numbers do you want to print: ");
                input1 = Console.ReadLine();
            }
            while (!int.TryParse(input1, out upperBound) || upperBound <= lowerBound);

            // print result
            Console.WriteLine("The first {0} Fibonacci numbers are:", upperBound);
            int numbersPerLine = 5;

            int beforeLast = 0;
            int last = 1;
            for (int i = lowerBound; i <= upperBound; i++)
            {
                // calculate i-th Fibonacci
                int current = beforeLast + last;

                // prevent overflow 
                if (current < 0)
                {
                    Console.WriteLine("Integer value hold up to: {0} Fibonacci.", i);
                    break;
                }

                // print i-th
                Console.Write("{0,-11}", current);
                if (i % numbersPerLine == 0)
                {
                    Console.Write("\n");
                }

                // increment
                beforeLast = last;
                last = current;
            }
        }
    }
}
