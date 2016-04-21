/*
  <summary>    
  TITLE              Even or Odd                       Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>05.04.2016</datecreated>
*/
using System;

namespace Even_Or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            var variable = int.Parse(Console.ReadLine());

            if (variable % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
