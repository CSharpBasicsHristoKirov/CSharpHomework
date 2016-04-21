/*
  <summary>    
  TITLE              Numbers from 1 to 100             Program.cs
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

namespace Numbers1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 100;
            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
