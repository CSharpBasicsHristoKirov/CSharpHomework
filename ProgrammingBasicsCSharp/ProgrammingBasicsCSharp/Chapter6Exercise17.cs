/*
   <summary>     
   TITLE              Greatest Common Divisor  Chapter6Exercise17.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Find the greatest common divisor
                      of two integers.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>07.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise17
    {
        static void Main()
        {
            Console.WriteLine("Type the first integer: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the second integer: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("The GCD of {0} and {1}, using Euclid's algorithm, is {2}.", a, b, EuclidGCD(a, b));
        }
        //---------------------------------------------------------------------------------------

        /*
           Method: EuclidGCD(int a, int b);

           It retunrs the greatest common divisor
           of a and b using Euclid's algorithm recursively.
       */
        static int EuclidGCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            // arguments: divisor, remainder
            return EuclidGCD(b, a % b);
        }
    }
}
