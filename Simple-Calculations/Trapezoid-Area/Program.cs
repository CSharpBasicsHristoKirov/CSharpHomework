/*
  <summary>    
  TITLE               Trapezoid area                   Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective:  Read trapezoid small-, large- base and height.
                      Print trapezoid area.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>27.03.2016</datecreated>
*/
using System;

namespace Trapezoid_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = (b1 + b2) * h / 2.0d;
            Console.WriteLine("Trapezoid area = " + area);
        }
    }
}
