/*
  <summary>    
  TITLE              Fibonacci                         Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Prit the n-th Fibonaccin number.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>18.04.2016</datecreated>
*/
using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var fibonacci1 = 1;
            var fibonacci2 = 1;

            if (n >= 2)
            {
                for (var i = 0; i < n; i++)
                {
                    var fibonacciNext = fibonacci1 + fibonacci2;

                    fibonacci1 = fibonacci2;
                    fibonacci2 = fibonacciNext;
                }
            }

            Console.WriteLine(fibonacci1);
        }
    }
}
