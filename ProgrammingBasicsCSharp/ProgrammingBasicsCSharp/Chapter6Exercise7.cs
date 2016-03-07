/*
   <summary>    
   TITLE              N! * K! / (N - K)!       Chapter6Exercise7.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Calculate N! * K! / (N - K)!, where 1 < K < N. 
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
    class Chapter6Exercise7
    {
        /*
           Method: double p = factorial(n)

           It returns the factorial of n.
       */
        static double factorial(int n)
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
            int k = int.Parse(Console.ReadLine());

            double result = (factorial(n) * factorial(k)) / factorial(n - k);
            Console.WriteLine(result);
        }
    }
}
