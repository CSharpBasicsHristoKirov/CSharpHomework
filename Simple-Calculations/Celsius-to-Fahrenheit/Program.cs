/*
  <summary>    
  TITLE              Temperature unit convertion       Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read temperature in Celsius. 
                     Print in Fahreheit. 
                     (Round to second digit after the decimal point)
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>28.03.2016</datecreated>
*/
using System;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = double.Parse(Console.ReadLine());
            double f = c * 1.8d + 32d;
            Console.WriteLine(Math.Round(f, 2));
        }
    }
}
