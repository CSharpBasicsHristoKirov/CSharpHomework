/*
  <summary>    
  TITLE              Circle area and perimeter         Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read circle radius. 
                     Print its area and perimeter.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>27.03.2016</datecreated>
*/
using System;

namespace Circle_Perimeter_and_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = {0}", Math.PI * radius * radius);
            Console.WriteLine("Perimeter = {0}", 2 * Math.PI * radius);
        }
    }
}
