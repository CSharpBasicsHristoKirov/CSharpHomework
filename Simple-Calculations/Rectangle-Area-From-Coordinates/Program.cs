/*
  <summary>    
  TITLE              Rectangle area from cooridnates   Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read coordinates from two opposite vertexes
                     of a rectangel. 
                     Print rectangle area and perimeter.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>27.03.2016</datecreated>
*/
using System;

namespace Rectangle_Area_From_Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var rectBase = Math.Abs(x1 - x2);
            var rectHeight = Math.Abs(y1 - y2);

            var area = rectBase * rectHeight;
            var perimeter = 2 * (rectBase + rectHeight);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
