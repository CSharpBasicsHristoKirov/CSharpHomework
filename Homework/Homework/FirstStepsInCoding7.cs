/*
  <summary>    
  TITLE              Rectangle area        FirstStepsInCoding7.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read a and b and print the area of rectangle
                     with sides a and b.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>27.03.2016</datecreated>
*/
using System;

namespace Homework
{
    class FirstStepsInCoding7
    {
        static void Main()
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());

            Console.WriteLine(a * b);
        }
    }
}
