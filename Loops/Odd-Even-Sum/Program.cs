/*
  <summary>    
  TITLE              Odd Even Sum                      Program.cs
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

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int evenSum = 0, oddSum = 0;
            for (int i = 1; i <= length; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += int.Parse(Console.ReadLine());
                }
                else
                {
                    oddSum += int.Parse(Console.ReadLine());
                }
            }            

            int difference = Math.Abs(evenSum - oddSum);
            if (difference == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", evenSum);

            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", difference);
            }
        }
    }
}
