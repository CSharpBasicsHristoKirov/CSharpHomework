/*
  <summary>    
  TITLE              Illuminati Lock                   Program.cs
  Basic Level - Programming Basics - Exam_17_January_2016_Morning
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>22.04.2016</datecreated>
*/
using System;

namespace Illuminati_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char background = '.';
            char eye = '#';

            // top
            Console.Write(new string(background, n));
            Console.Write(new string(eye, n));
            Console.WriteLine(new string(background, n));

            // middle
            int width = 0;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(background, n - 2 - width));
                Console.Write(new string(eye, 2));
                Console.Write(new string(background, width));
                Console.Write(new string(eye, 1));

                Console.Write(new string(background, n - 2));

                Console.Write(new string(eye, 1));
                Console.Write(new string(background, width));
                Console.Write(new string(eye, 2));
                Console.WriteLine(new string(background, n - 2 - width));

                if (i < n / 2 - 1)
                {
                    width += 2;
                }
                else if (i == n / 2 - 1)
                {

                }
                else
                {
                    width -= 2;
                }
            }

            // bottom
            Console.Write(new string(background, n));
            Console.Write(new string(eye, n));
            Console.WriteLine(new string(background, n));
        }
    }
}
