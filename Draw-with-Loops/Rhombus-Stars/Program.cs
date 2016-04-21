/*
  <summary>    
  TITLE              Rhombus Stars                     Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Print a rhombus size n x n. 
                     Example: n = 2
                      *
                     * *
                      *
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Rhombus_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            char symbol = '*';
            char space = ' ';

            // upper half + middle
            for (int i = 1; i <= length; i++)
            {
                Console.Write(new string(space, length - i));
                Console.Write(symbol);
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" " + symbol);
                }
                Console.WriteLine();
            }

            // lower half
            for (int i = length - 1; i >= 1; i--)
            {
                Console.Write(new string(space, length - i));
                Console.Write(symbol);
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(" " + symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
