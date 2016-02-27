/*
   <summary>  
   TITLE              Number of divisible to 5  Chapter4Exercise5.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read two integers: min, max.
                      Count number of integers such that: % 5 == 0
                      withinL [min, max].
               Input: 1
                      10
              Output: The number of divisble by 5 within [1, 10] is 2.
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter4Exercise5
    {
        /*
            Method: numberOfDivisible();

            Returns the number of integers
            divisible by the third parameter
            within an interval specified by the
            first two parameters.
        */
        static int numberOfDivisible(int min, int max, int denominator)
        {
            int count = 0;
            for (int i = min; i <= max; i++)
            {
                if (i % denominator == 0)
                {
                    ++count;
                }
            }
            return count;
        }

        static void Main()
        {
            // information
            Console.WriteLine("Find number of integers divisible to 5 in an interval.");

            // read input
            Console.WriteLine("Type lower bound:");
            int lowerBound = int.Parse(Console.ReadLine());

            Console.WriteLine("Type upper bound:");
            int upperBound = int.Parse(Console.ReadLine());

            // print result
            int denominator = 5;
            Console.WriteLine("The number of divisble by {0} within [{1}, {2}] is {3}.",
                              denominator, lowerBound, upperBound, 
                              numberOfDivisible(lowerBound, upperBound, denominator));
        }
    }
}
