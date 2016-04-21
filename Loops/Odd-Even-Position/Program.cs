/*
  <summary>    
  TITLE              Odd Even Position                 Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n; Find the sum, max and min for the even and odd
                     numbers up to n. If some of the variables has no value
                     print: "No".   
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            float evenSum = 0, evenMin = float.MaxValue, evenMax = float.MinValue;
            float oddSum = 0, oddMin = float.MaxValue, oddMax = float.MinValue;
            for (int i = 1; i <= length; i++)
            {
                if (i % 2 == 0)
                {
                    float current = float.Parse(Console.ReadLine());
                    evenMin = Math.Min(evenMin, current);
                    evenMax = Math.Max(evenMax, current);
                    evenSum += current;
                }
                else
                {
                    float current = float.Parse(Console.ReadLine());
                    oddMin = Math.Min(oddMin, current);
                    oddMax = Math.Max(oddMax, current);
                    oddSum += current;
                }
            }
            Console.WriteLine("OddSum={0}", oddSum);

            if (oddMax == float.MinValue)
            {
                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin={0}", oddMin);
            }

            if (oddMin == float.MaxValue)
            {
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMax={0}", oddMax);
            }

            Console.WriteLine("EvenSum={0}", evenSum);

            if (evenMin == float.MaxValue)
            {
                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0}", evenMin);
            }

            if (evenMax == float.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax={0}", evenMax);
            }
        }
    }
}