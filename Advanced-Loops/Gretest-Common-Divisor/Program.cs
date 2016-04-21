/*
  <summary>    
  TITLE              Gretest Common Divisor            Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read two positive integers, a and b. 
                     Print their greatest common divisor.

                     Implement the Euclid's algorithm.
                     Divide a by b and take the remainder
                     the dividend, a, becomes the previous divisor, b, 
                     the divisor, b, becomes the remainder of a % b;
                     The last divisor (before (remainder) b == 0) is the GCD.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>18.04.2016</datecreated>
*/
using System;

namespace Gretest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                int previousDivisor = b;
                b = a % b;
                a = previousDivisor;
            }

            Console.WriteLine(a);
        }
    }
}
