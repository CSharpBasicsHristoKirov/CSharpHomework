/*
  <summary>    
  TITLE              Square of stars       FirstStepsInCoding8.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read N, where 2 <= N <= 100.
                     Print a square with side N,
                     using the symbol '*'. 
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>27.03.2016</datecreated>
*/
using System;

namespace Homework
{
    class FirstStepsInCoding8
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            string line = new string('*', n);
            Console.WriteLine(line);

            int length = n - 2;
            for (int i = 0; i < length; i++)
            {
                Console.Write("*");

                string space = new string(' ', length);
                Console.Write(space);

                Console.Write("*\n");
            }
            
            Console.WriteLine(line);
        }
    }
}
