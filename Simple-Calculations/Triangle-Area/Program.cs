/*
  <summary>    
  TITLE              Triangle area                     Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read side and height. Print area of triangle.  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>28.03.2016</datecreated>
*/
using System;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            double h= double.Parse(Console.ReadLine());
            double area = b * h / 2.0d;
            Console.WriteLine("Triangle area = {0}", Math.Round(area, 2));
        }
    }
}
