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

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise7
    {
       

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}! * {1}! / {2}! = {3}",n, k, n - k, Combination(n, k)  * Factorial(k));
        }
        //--------------------------------------------------------------------

        /*
          Method: double p = Factorial(n)

          It returns the factorial of n.
        */
        static double Factorial(int n)
        {
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        //--------------------------------------------------------------------

        /*
          Method:  double Combination( int n, int k)

           It returns the k - combination of a set of
           n elements.
        */
        static double Combination(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }
    }
}
