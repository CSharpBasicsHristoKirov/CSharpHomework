/*
  <summary>    
  TITLE              Histogram                         Program.cs
  Basic Level  -  Programming Basics - Exam 06.03.2016 Exercise 4
  COMMENT
          Objective: Read n; Type n numbers and calculate what 
                     percent of them are:
                     p1 [..., 200)
                     p2 [200, 400)
                     p3 [400, 600)
                     p4 [600, 800)
                     p5 [800, ...)
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            float p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

            for (int i = 0; i < length; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    ++p1;
                }
                else if (number >= 200 && number < 400)
                {
                    ++p2;
                }
                else if (number >= 400 && number < 600)
                {
                    ++p3;
                }
                else if (number >= 600 && number < 800)
                {
                    ++p4;
                }
                else if (number >= 800)
                {
                    ++p5;
                }
            }

            p1 *= (100.0f / length);
            p2 *= (100.0f / length);
            p3 *= (100.0f / length);
            p4 *= (100.0f / length);
            p5 *= (100.0f / length);

            Console.WriteLine("{0:F2}%\n{1:F2}%\n{2:F2}%\n{3:F2}%\n{4:F2}%\n", Math.Round(p1, 2), Math.Round(p2, 2), Math.Round(p3, 2), Math.Round(p4, 2), Math.Round(p5, 2));
        }
    }
}
