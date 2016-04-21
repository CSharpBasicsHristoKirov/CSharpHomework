/*
  <summary>    
  TITLE              Equal Pairs                       Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n; Type n pairs of numbers.
                     Print: "Yes", value=..., if the sums of all 
                     pairs are equal.
                     Print: "No", maxdiff=..., where maxdiff is 
                     the difference between two consecutive pairs.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int previousSum = 0;
            int currentSum = 0;
            int difference = int.MinValue;
            bool equal = true;

            for (int i = 0; i < length; i++)
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                currentSum = first + second;

                if (i != 0)
                {
                    if (currentSum != previousSum)
                    {
                        equal = false;
                        difference = Math.Max(difference, Math.Abs(currentSum - previousSum));
                    }
                }

                previousSum = currentSum;
            }

            if (equal)
            {
                Console.WriteLine("Yes, value={0}", currentSum);
            }
            else
            {
                if (difference == 0)
                {
                    Console.WriteLine("Yes, maxdiff={0}", difference);
                }
                else
                {
                    Console.WriteLine("No, maxdiff={0}", difference);
                }
            }
        }
    }
}
