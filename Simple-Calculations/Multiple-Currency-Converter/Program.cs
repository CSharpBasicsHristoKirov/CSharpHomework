/*
  <summary>    
  TITLE              Currency converter                Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read currency value, input currency suffix,
                     output currencu suffix. 
                     (valid suffixes: BGN, EUR, USD, GBP) 
                     (Round to second digit after the decimal point)
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>28.03.2016</datecreated>
*/
using System;
using System.Collections.Generic;

namespace Multiple_Currency_Converter
{
    class Program
    {
        static Dictionary<string, double> rates = new Dictionary<string, double>
        {
            {"BGN", 1.00000d},
            {"USD", 1.79549d},   
            {"EUR", 1.95583d}, 
            {"GBP", 2.53405d}  
        };

        static void Main(string[] args)
        {
            double initial = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            double final = initial * rates[input] / rates[output];

            Console.WriteLine("{0} {1}", Math.Round(final, 2), output);
        }
    }
}
