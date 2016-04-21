/*
  <summary>    
  TITLE              Point In Rectangle                Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read the coordinates of the top left and 
                     bottom right vertices of a rectangle, 
                     followed by the coordinates of a point.
                     Print whether the point "Inside" or "Outside"
                     of the rectangle.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>06.04.2016</datecreated>
*/
using System;

namespace Point_In_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            
            if (x >= x1 && x <= x2 &&  // x between the vertical edges
                y >= y1 && y <= y2)    // y between the horizontal edges
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
