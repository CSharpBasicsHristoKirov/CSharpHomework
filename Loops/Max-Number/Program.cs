/*
  <summary>    
  TITLE              Max Number                        Program.cs
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

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            for (int i = 0; i < length; i++)
            {
                max = Math.Max(int.Parse(Console.ReadLine()), max);
            }
            Console.WriteLine(max);
        }
    }
}
