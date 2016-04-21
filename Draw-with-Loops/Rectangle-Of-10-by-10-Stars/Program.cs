/*
  <summary>    
  TITLE              Rectangle if 10 by 10 Stars       Program.cs
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

namespace Rectangle_Of_10_by_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            char symbol = '*';
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(new string(symbol, length));
            }
        }
    }
}
