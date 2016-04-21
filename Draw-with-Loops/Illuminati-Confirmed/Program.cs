/*
  <summary>    
  TITLE              Triangle of dollars               Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Print a triangle with n x n 
                     using symbols: '$'. 
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Illuminati_Confirmed
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            char symbol = '$';

            for (int i = 1; i <= length; i++)
            {
                Console.Write(symbol);
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" " + symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
