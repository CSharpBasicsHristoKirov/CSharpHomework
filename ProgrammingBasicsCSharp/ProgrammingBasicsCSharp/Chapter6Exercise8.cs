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
        static void Main()
        {
            Console.WriteLine("Which Catalan number do you want to see:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The {0}th Catalan number is {1}", n, CatalanNumber(n));
        }
        //----------------------------------------------------------------------------------------

        /*
            Method: double p = factorial(n)

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
        //----------------------------------------------------------------------------------------

        /*
            Method: double k = CatalanNumber(n)

            It returns the n-th Catalan number.
        */
        static double CatalanNumber(int n)
        {
            const int multiplier = 2;
            return Factorial(multiplier * n) / (Factorial(n + 1) * Factorial(n));
        }
    }
}
