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
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise17
    {
         

        /*
            Method: int gcd = euclidGCD(int a, int b);

            It retunrs the greatest common divisor
            of a and b using Euclid's algorithm recursively.
        */
        static int euclidGCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return euclidGCD(b, a % b);
        }

        static void Main()
        {
            Console.WriteLine("Type the first integer: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the second integer: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("The Euclid's GCD of {0} and {1} is {2}.", a, b, euclidGCD(a, b));
        }
    }
}
