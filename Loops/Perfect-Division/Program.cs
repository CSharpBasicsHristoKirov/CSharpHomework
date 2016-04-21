/*
  <summary>    
  TITLE              Perfect Division                  Program.cs
  Basic Level  -  Programming Basics - Exam 26.03.2016 Exercise 4
  COMMENT
          Objective: Read n; Type n numbers and calculate what 
                     percent of them are:
                     p1 , perfectly divisible by 2.
                     p2 , perfectly divisible by 3.
                     p3 , perfectly divisible by 3.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Perfect_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            float p1 = 0, p2 = 0, p3 = 0;

            for (int i = 0; i < length; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    ++p1;
                }

                if (number % 3 == 0)
                {
                    ++p2;
                }

                if (number % 4 == 0)
                {
                    ++p3;
                }
            }

            p1 *= (100.0f / length);
            p2 *= (100.0f / length);
            p3 *= (100.0f / length);

            Console.WriteLine("{0:F2}%\n{1:F2}%\n{2:F2}%\n", Math.Round(p1, 2), Math.Round(p2, 2), Math.Round(p3, 2));
        }
    }
}
