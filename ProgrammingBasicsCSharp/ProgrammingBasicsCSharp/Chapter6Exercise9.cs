/*
   <summary>     
   TITLE              Power series             Chapter6Exercise9.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Calculate the series n!/ x^n.  (1/ e^x)?
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
    class Chapter6Exercise9
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

        /*
           Method: double sum = series(int n, int x);

           It returns the sum of n!/ x^n.
        */
        static double series(int n, int x)
        {
            double sum = 1;
            for (int i = 0; i < n; i++)
            {
                sum += (factorial(i) / Math.Pow(x, i));
            }
            return sum;
        }

        static void Main()
        {
            Console.WriteLine("Type x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Type n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Series: " + series(n, x));
        }
    }
}
