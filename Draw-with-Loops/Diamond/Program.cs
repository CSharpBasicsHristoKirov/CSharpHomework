/*
  <summary>    
  TITLE              Diamond                           Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Print a "Diamont" of size: n. 
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char symbol = '*';
            char space = '-';

            // top + middle
            int length = (n + 1) / 2;
            for (int i = 0; i < length; ++i)
            {
                if (n % 2 == 0)
                {
                    Console.Write(new string(space, n / 2 - 1 - i));
                    Console.Write(symbol);
                    Console.Write(new string(space, (i + 1) * 2 - 2));
                    Console.Write(symbol);
                    Console.Write(new string(space, n / 2 - 1 - i));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string(space, n / 2 - i));
                    Console.Write(symbol);
                    if (i > 0) Console.Write(new string(space, i * 2 - 1));
                    if (i > 0) Console.Write(symbol);
                    Console.Write(new string(space, n / 2 - i));
                    Console.WriteLine();
                }
            }

            // bottom
            for (int i =  length - 2; i >= 0; --i)
            {
                if (n % 2 == 0)
                {
                    Console.Write(new string(space, n / 2 - 1 - i));
                    Console.Write(symbol);
                    Console.Write(new string(space, (i + 1) * 2 - 2));
                    Console.Write(symbol);
                    Console.Write(new string(space, n / 2 - 1 - i));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string(space, n / 2 - i));
                    Console.Write(symbol);
                    if (i > 0) Console.Write(new string(space, i * 2 - 1));
                    if (i > 0) Console.Write(symbol);
                    Console.Write(new string(space, n / 2 - i));
                    Console.WriteLine();
                }
            }
        }
    }
}
