/*
  <summary>    
  TITLE              Magic Wand                        Program.cs
  Basic Level  -  Programming Basics - Exam_29_March_2015_Evening
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>21.04.2016</datecreated>
*/
using System;

namespace Magic_Wand
{
    class Program
    {
        static void Main(string[] args)
        {
            // Warning!!! Ugly code ahead.
            int n = int.Parse(Console.ReadLine());

            char background = '.';
            char wandFrame = '*';

            // top
            Console.Write(new string(background, (3 * n + 2) / 2));
            Console.Write(wandFrame);
            Console.WriteLine(new string(background, (3 * n + 2) / 2));

            // upper half
            int width = (3 * n + 2) / 2;
            int fillingWidth = 1;
            do
            {
                width--;

                Console.Write(new string(background, width));
                Console.Write(wandFrame);
                Console.Write(new string(background, fillingWidth));
                Console.Write(wandFrame);
                Console.WriteLine(new string(background, width));

                fillingWidth += 2;
            } while (width > n);

            // horizontal line
            Console.Write(new string(wandFrame, n));
            Console.Write(new string(background, n + 2));
            Console.WriteLine(new string(wandFrame, n));

            // uper part 
            int width2 = 1;
            int length = n / 2;
            for (int i = 0; i < length; i++)
            {
                Console.Write(new string(background, width2));
                Console.Write(wandFrame);
                Console.Write(new string(background, 3 * n - 2 * width2));
                Console.Write(wandFrame);
                Console.WriteLine(new string(background, width2));
                ++width2;
            }

            // lower part
            --width2;
            int width3 = 0;
            while (width2 > 0) 
            {
                --width2;
                Console.Write(new string(background, width2));
                Console.Write(wandFrame);
                Console.Write(new string(background, n / 2));
                Console.Write(wandFrame);
                Console.Write(new string(background, width3));
                Console.Write(wandFrame);

                Console.Write(new string(background, n));

                Console.Write(wandFrame);
                Console.Write(new string(background, width3));
                Console.Write(wandFrame);
                Console.Write(new string(background, n / 2));
                Console.Write(wandFrame);
                Console.WriteLine(new string(background, width2));
                ++width3;
            }

            // horizontal line
            Console.Write(new string(wandFrame, n - n / 2));
            Console.Write(new string(background, n / 2));
            Console.Write(wandFrame);

            Console.Write(new string(background, n));

            Console.Write(wandFrame);
            Console.Write(new string(background, n / 2));
            Console.WriteLine(new string(wandFrame, n - n / 2));

            // handle
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(background, n));
                Console.Write(wandFrame);
                Console.Write(new string(background, n));
                Console.Write(wandFrame);
                Console.WriteLine(new string(background, n));
            }

            // base
            Console.Write(new string(background, n));
            Console.Write(new string(wandFrame, n + 2));
            Console.WriteLine(new string(background, n));
        }
    }
}
