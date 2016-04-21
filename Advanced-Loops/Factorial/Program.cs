/*
  <summary>    
  TITLE              Factorial                         Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Print n!.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>18.04.2016</datecreated>
*/
using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var factorial = 1;
            do
            {
                factorial *= n;
                n--;
            } while (n > 1);

            Console.WriteLine(factorial);
        }
    }
}
