
/*
  <summary>    
  TITLE              Metric Converter                  Program.cs
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
using System.Collections.Generic;

namespace Metric_Converter
{
    class Program
    {
        public static Dictionary<string, double> ConversionTable = new Dictionary<string, double>
        {
            // Imperial
            {"in", 39.3700787 },
            {"ft", 3.2808399 },
            {"yd", 1.0936133  },
            {"mi", 0.000621371192 },

            // Metric
            {"km", 0.001 },
            {"m", 1 },
            {"cm", 100 },
            {"mm", 1000 },
        };

        //==========================================================================================
        static void Main(string[] args)
        {
            double InputValue = double.Parse(Console.ReadLine());
            string InputUnit = Console.ReadLine();
            string OutputUnit = Console.ReadLine();

            double OutputValue = InputValue * ConversionTable[OutputUnit] / ConversionTable[InputUnit];

            Console.WriteLine("{0} {1}", OutputValue, OutputUnit);
        }
    }
}
