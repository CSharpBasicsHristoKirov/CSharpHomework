/*
   <summary>    
   TITLE             Catalan’s numbers         Chapter6Exercise8.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Calculate (2n)! / ((n + 1)! * n!), n >= 0.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>06.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise8
    {
        /*
          Method: double p = factorial(n)

          It returns the factorial of n.
        */
        static double factorial(double n)
        {
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            const int multiplier = 2;
            double catalanNumber = factorial(multiplier * n) / (factorial(n + 1) * factorial(n));

            Console.WriteLine(catalanNumber);
        }
    }
}
