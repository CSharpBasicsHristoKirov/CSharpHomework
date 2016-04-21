/*
  <summary>    
  TITLE              Sum Seconds                       Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>05.04.2016</datecreated>
*/
using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = int.Parse(Console.ReadLine());
            var t2 = int.Parse(Console.ReadLine());
            var t3 = int.Parse(Console.ReadLine());
            int sum = t1 + t2 + t3;
            Console.WriteLine("{0}:{1,2:0#}", sum / 60, sum % 60);
        }
    }
}
