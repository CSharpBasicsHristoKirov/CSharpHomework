/*
  <summary>    
  TITLE              Currency converter                Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read currency in USD. 
                     Print its BGN value. 
                     (Round to second digit after the decimal point)
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>28.03.2016</datecreated>
*/
using System;


namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double BGN = USD * 1.79549d;
            Console.WriteLine(Math.Round(BGN, 2));
        }
    }
}
