/*
  <summary>    
  TITLE              Sequence 2k plus 1                Program.cs
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

namespace Sequence_2k_plus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;
            while(num <= n)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }
        }
    }
}
