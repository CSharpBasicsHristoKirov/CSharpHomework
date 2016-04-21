/*
  <summary>    
  TITLE              Invalid Number                    Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read the an integer. 
                     Print "invalid" if != 0 or outside of [100, 200].
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>06.04.2016</datecreated>
*/
using System;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0 || (number >= 100 && number <= 200))
            {
                // valid
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
