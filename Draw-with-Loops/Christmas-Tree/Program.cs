/*
  <summary>    
  TITLE              Christmas Tree                    Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Print a "Chrismas Tree" of size n. 
                     Example: n = 3
                         |
                       * | *
                      ** | **
                     *** | ***    
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char stem = '|';
            char branch = '*';
            char space = ' ';

            // print top
            Console.Write(new string(space, n + 1));
            Console.WriteLine(stem);

            // print rest
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(space, n - i));
                Console.Write(new string(branch, i));
                Console.Write(space);

                Console.Write(stem);

                Console.Write(space);
                Console.Write(new string(branch, i));
                Console.WriteLine();
            }
        }
    }
}
