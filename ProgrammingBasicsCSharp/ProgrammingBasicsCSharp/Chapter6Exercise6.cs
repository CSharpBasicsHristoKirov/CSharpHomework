/*
   <summary>    
   TITLE              Ratio of factorials      Chapter6Exercise6.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Calculate N!/K!, where 1 < K < N. 
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
    class Chapter6Exercise6
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            
            Console.WriteLine("N! / K! = {0}", factorial(n)/ factorial(k));
        }
        //----------------------------------------------------------------------

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
    }
}
