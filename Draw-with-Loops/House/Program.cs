/*
  <summary>    
  TITLE              House                             Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Print a "House" of size: n x n. 
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char symbol = '*';
            char space = '-';
            char wall = '|';

            // roof
            int length = (n + 1) / 2;
            for (int i = 0; i < length; ++i)
            {
                if (n % 2 == 0)
                {
                    Console.Write(new string(space, n / 2 - 1 - i));
                    Console.Write(new string(symbol, (i + 1) * 2));
                    Console.Write(new string(space, n / 2 - 1 - i));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string(space, n / 2 - i));
                    Console.Write(new string(symbol, i * 2 + 1));
                    Console.Write(new string(space, n / 2 - i));
                    Console.WriteLine();
                }
            }

            // room
            int length2 = (n / 2);
            for (int i = 1; i <= length2; i++)
            {
                Console.Write(wall);
                Console.Write(new string(symbol, n - 2));
                Console.Write(wall);
                Console.WriteLine();
            }
        }
    }
}
