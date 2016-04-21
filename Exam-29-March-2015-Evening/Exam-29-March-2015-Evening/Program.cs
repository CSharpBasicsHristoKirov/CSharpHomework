/*
  <summary>    
  TITLE              Currency Check                    Program.cs
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

namespace Exam_29_March_2015_Evening
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal min = decimal.MaxValue;
            int length = 5;
            decimal[] prices = new decimal[length];

            for (int i = 0; i < length; i++)
            {
                prices[i] = decimal.Parse(Console.ReadLine());

                // convet to leva
                if (i == 0)
                {
                    prices[i] = (prices[i] / 100m) * 3.5m; // rubles
                }
                else if (i == 1)
                {
                    prices[i] *= 1.5m; // dollars
                }
                else if (i == 2)
                {
                    prices[i] *= 1.95m; // euro
                }
                else if (i == 3)
                {
                    prices[i] /= 2m; // 2 games for the price of one
                }

                // find min
                min = Math.Min(min, prices[i]);
            }

            Console.WriteLine("{0:f2}", min);
        }
    }
}
