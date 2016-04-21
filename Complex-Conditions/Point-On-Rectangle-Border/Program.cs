/*
  <summary>    
  TITLE              Point On Rectangle Border         Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read the product. 
                     Print "fruit" or "vetetable" if it matches
                     in the listed, otherwise print "unknown".
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>06.04.2016</datecreated>
*/
using System;

namespace Point_On_Rectangle_Border
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

            if ( ( (x == x1 || x == x2) && y >= y1 && y <= y2 ) || // x on the vertical edges
                 ( (y == y1 || y == y2) && x >= x1 && x <= x2 ) )   // y on the horizontal edges
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
