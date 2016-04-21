/*
  <summary>    
  TITLE              Bonus score                       Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Scale a variable depending on its value.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>05.04.2016</datecreated>
*/
using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());

            double numberWithScore = number;
            if (number <= 100)
            {
                numberWithScore += 5;
            }
            else if (number > 100 && number <= 1000)
            {
                numberWithScore += numberWithScore * 0.20;
            }
            else if (number > 1000)
            {
                numberWithScore += numberWithScore * 0.10;
            }

            if (number % 2 == 0)
            {
                numberWithScore += 1;
            }
            else if (number % 5 == 0)
            {
                numberWithScore += 2;
            }

            Console.WriteLine(numberWithScore - number);
            Console.WriteLine(numberWithScore);
        }
    }
}
