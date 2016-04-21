/*
  <summary>    
  TITLE              Numbers ending in 7               Program.cs
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

namespace Numbers_Ending_In_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 1000;
            for (int i = 0; i <= length; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
