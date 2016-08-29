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
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of zeroes: in {0} is {1}", Factorial(n), CountTrailingZeroes(n));
        }
        //-----------------------------------------------------------------------------------------------
        /*
           Method: int f = Factorial(n);

           It returns the factorial of n.
        */
        static int Factorial(int n)
        {
            if (n < 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        //-----------------------------------------------------------------------------------------------

        /*
            Method: CountTrailingZeroes(int n);

            It counts how many times the remainder of division
            by 10 is equal to 0.
        */
        static int CountTrailingZeroes(int n)
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
    }
}
