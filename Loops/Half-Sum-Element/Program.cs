/*
  <summary>    
  TITLE              Half Sum Element                  Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int sum = 0, max = int.MinValue;
            for (int i = 0; i < length; i++)
            {
                int current = int.Parse(Console.ReadLine());

                max = Math.Max(current, max);

                sum += current;
            }

            int difference = Math.Abs(sum - 2 * max);
            if (difference == 0)
            {
                sum -= max;
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", difference);
            }
        }
    }
}
