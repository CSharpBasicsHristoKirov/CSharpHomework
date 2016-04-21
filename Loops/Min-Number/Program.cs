/*
  <summary>    
  TITLE              Min Number                        Program.cs
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
            int min = int.MaxValue;
            for (int i = 0; i < length; i++)
            {
                min = Math.Min(int.Parse(Console.ReadLine()), min);
            }
            Console.WriteLine(min);
        }
    }
}
