/*
  <summary>    
  TITLE              Number Pyramid                    Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Print a pyramid of increasing numbers,
                     where each row length increases by 1 from the previous.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>18.04.2016</datecreated>
*/
using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numbersPerLine = 2;
            int currentNumber = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                currentNumber++;

                if (currentNumber == numbersPerLine)
                {
                    Console.WriteLine();
                    currentNumber = 1;
                    numbersPerLine++;
                }
            }
            Console.WriteLine();
        }
    }
}
