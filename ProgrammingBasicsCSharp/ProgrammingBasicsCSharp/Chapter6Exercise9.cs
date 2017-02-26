/*
   <summary>     
   TITLE              Power series             Chapter6Exercise9.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Calculate the series n!/ x^n.   
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
        static void Main()
        {
            Console.WriteLine("Type x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Type n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of the series:\n S = 1 + 1! / {0} + 2! / {1}^2 + ... + {2}! / {3}^{4} is: {5}",x, x, n, x, n, Series(n, x));
        }
        //---------------------------------------------------------

        /*
          Method: double p = Factorial(n)

          It returns the factorial of n.
        */
        static double Factorial(double n)
        {
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        //---------------------------------------------------------

        /*
           Method: double sum = Series(int n, int x);

           It returns the sum of the series: n! / x^n.
        */
        static double Series(int n, int x)
        {
            double sum = 1;
            for (int i = 0; i < n; i++)
            {
                sum += (Factorial(i) / Math.Pow(x, i));
            }
            return sum;
        }

        //---------------------------------------------------------

        /*
           Method: double sum = pSeries(int limit, int n);

           It returns the sum of the series: 1 / n^p.
        */
        static double pSeries(int limit, int x)
        {
            double sum = 1;
            for (int i = 0; i < limit; i++)
            {
                sum += (1.0f / Math.Pow(i, 4));
            }
            return sum;
        }


    }
}
