/*
  <summary>    
  TITLE              Square Of Stars                   Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Print n x n square
                     using equidistantly located symbols: '*'. 
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Square_Of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            char symbol = '*';

            for (int i = 0; i < length; i++)
            {
                Console.Write(symbol);
                for (int j = 0; j < length - 1; j++)
                {
                    Console.Write(" " + symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
