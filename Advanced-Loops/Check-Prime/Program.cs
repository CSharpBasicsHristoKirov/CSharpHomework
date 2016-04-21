/*
  <summary>    
  TITLE              Check Prime                      Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Check if n is prime and print:
                     "Prime"
                     "Not Prime"
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>18.04.2016</datecreated>
*/
using System;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeMessage = "Prime";
            string notPrimeMessage = "Not Prime";

            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (n >= 2 && isPrime)
            {
                Console.WriteLine(primeMessage);
            }
            else
            {
                Console.WriteLine(notPrimeMessage);
            }
        }
    }
}
