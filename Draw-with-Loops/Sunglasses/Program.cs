/*
  <summary>    
  TITLE              Sunglasses                        Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Print a "Sungalasses" of size 5 * n x n. 
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char frame = '*';
            char lens = '/';
            char bridge = '|';
            char space = ' ';

            // top vertical part of the frame
            Console.Write(new string(frame, 2 * n));
            Console.Write(new string(space, n));
            Console.Write(new string(frame, 2 * n));
            Console.WriteLine();

            // lenses & bridge
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write(frame);
                Console.Write(new string(lens, (2 * n) - 2));
                Console.Write(frame);

                if (i == ((n - 1) / 2))
                {
                    Console.Write(new string(bridge, n));
                }
                else
                {
                    Console.Write(new string(space, n));
                }

                Console.Write(frame);
                Console.Write(new string(lens, (2 * n) - 2));
                Console.Write(frame);
                Console.WriteLine();
            }

            // bottom vertical part of the frame
            Console.Write(new string(frame, 2 * n));
            Console.Write(new string(space, n));
            Console.Write(new string(frame, 2 * n));
            Console.WriteLine();
        }
    }
}
