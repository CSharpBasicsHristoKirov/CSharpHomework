/*
  <summary>    
  TITLE              Rectangle if N by N Stars       Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Print n x n rectangle 
                     using the symbol: '*'. 
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>16.04.2016</datecreated>
*/
using System;

namespace Rectangle_Of_N_by_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            char symbol = '*';
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(new string(symbol, length));
            }
        }
    }
}
