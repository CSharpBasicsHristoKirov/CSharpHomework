/*
  <summary>    
  TITLE              Dumbbell                          Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>20.04.2016</datecreated>
*/
using System;

namespace Dumbbell
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char background = '.';
            char frame = '&';
            char filling = '*';
            char bar = '=';

            // top
            Console.Write(new string(background, n / 2));
            Console.Write(new string(frame, n - n / 2));
            Console.Write(new string(background, n));
            Console.Write(new string(frame, n - n / 2));
            Console.WriteLine(new string(background, n / 2));

            // main part
            int width = n / 2;
            bool increase = true;
            for (int i = 1; i <= n - 2; i++)
            {
                if (n - 2 - width > 0) Console.Write(new string(background, n - 2 - width));
                Console.Write(frame);
                Console.Write(new string(filling, width));
                Console.Write(frame);

                if (i == (n / 2))
                {
                    Console.Write(new string(bar, n));
                    increase = false;
                }
                else
                {
                    Console.Write(new string(background, n));

                }

                Console.Write(frame);
                Console.Write(new string(filling, width));
                Console.Write(frame);
                if (n - 2 - width > 0) Console.Write(new string(background, n - 2 - width));
                Console.WriteLine();


                if (increase)
                {
                    width++;
                }
                else
                {
                    width--;
                }
            }

            // bottom
            Console.Write(new string(background, n / 2));
            Console.Write(new string(frame, n - n / 2));
            Console.Write(new string(background, n));
            Console.Write(new string(frame, n - n / 2));
            Console.WriteLine(new string(background, n / 2));
        }
    }
}
