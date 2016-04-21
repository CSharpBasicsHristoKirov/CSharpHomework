/*
  <summary>    
  TITLE              Left and Right Sum                Program.cs
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

namespace Left_And_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int leftSum = 0;
            for (int i = 0; i < length; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
            }
            int rightSum = 0;
            for (int i = 0; i < length; i++)
            {
                rightSum += int.Parse(Console.ReadLine());
            }

            int difference = Math.Abs(leftSum - rightSum);
            if (difference == 0)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", difference);
            }
        }
    }
}
