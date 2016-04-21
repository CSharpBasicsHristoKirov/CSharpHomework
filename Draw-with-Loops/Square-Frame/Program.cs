/*
  <summary>    
  TITLE              Square Frame                      Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Print a square frame of size n x n. 
                     Example: n = 3
                     + - +
                     | - |
                     + - +
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char vertex = '+';
            char horizontalSide = '-';
            char verticalSide = '|';
            char filling = '-';

            // top edge
            Console.Write(vertex + " ");
            int length = n - 2;
            for (int i = 0; i < length; i++)
            {
                Console.Write(horizontalSide + " ");
            }
            Console.WriteLine(vertex);

            // vertical edges and filling
            for (int i = 0; i < length; i++)
            {
                Console.Write(verticalSide + " ");
                for (int j = 0; j < length; j++)
                {
                    Console.Write(filling + " ");
                } 
                Console.WriteLine(verticalSide);
            }

            // bottom edge
            Console.Write(vertex + " ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(horizontalSide + " ");
            }
            Console.WriteLine(vertex);
        }
    }
}
