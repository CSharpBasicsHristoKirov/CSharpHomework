/*
   <summary>     
   TITLE              Count trailing zeroes   Chapter6Exercise11.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Calculate the number of zeroes at the end
                      of a number (result of a factorial).   
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
    class Chapter6Exercise11
    {
        /*
            Method: int f = factorial(n);

            It returns the factorial of n.
        */
        static int factorial(int n)
        {
            if (n < 1)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }

        /*
            Method: int zeroes = countTrailingZeroes(int n);

            It counts how many times the remainder of division
            by 10 is equal to 0.
        */
        static int countTrailingZeroes(int n)
        {
            int numberOfZeroes = 0;
            while (true)
            {
                // if remainder == 0 LSB is 0
                int remainder = n % 10;
                if (remainder == 0)
                {
                    numberOfZeroes++;
                }
                else
                {
                    break;
                }
                // trim LSB
                n /= 10;
            }
            return numberOfZeroes;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            n = factorial(n);

            Console.WriteLine("Number of zeroes: in {0} is {1}",n, countTrailingZeroes(n));
        }
    }
}
