/*
  <summary>    
  TITLE              Point In The Figure               Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read a scale factor and point coordinates.
                     Print whether the point is:
                     "inside"
                     "border"
                     "outside"
                     of a predefined rectangle.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>06.04.2016</datecreated>
*/
using System;

namespace Point_In_The_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int ScaleFactor = int.Parse(Console.ReadLine());
            int PointX = int.Parse(Console.ReadLine());
            int PointY = int.Parse(Console.ReadLine());

            // horizontal rectangle

            // upper left vertex
            int HorizontalX1 = 0;
            int HorizontalY1 = ScaleFactor;

            // bottom right vertex
            int HorizontalX2 = 3 * ScaleFactor;
            int HorizontalY2 = 0;

            bool InsideHorizontalRectangle = PointX > HorizontalX1 && PointX < HorizontalX2 && PointY < HorizontalY1 && PointY > HorizontalY2;

            // vertical rectangle

            // upper left vertex
            int VerticalX1 = ScaleFactor;
            int VerticalY1 = 4 * ScaleFactor;

            // bottom right vertex
            int VerticalX2 = 2 * ScaleFactor;
            int VerticalY2 = ScaleFactor;

            bool InsideVerticalRectangle = PointX > VerticalX1 && PointX < VerticalX2 && PointY < VerticalY1 && PointY > VerticalY2;

            bool InsideOnCommonEdge = PointY == VerticalY2 && PointX > VerticalX1 && PointX < VerticalX2;

            // determine point location relative to both rectangles
            bool Inside = InsideHorizontalRectangle || InsideVerticalRectangle || InsideOnCommonEdge;

            bool Outside = !InsideHorizontalRectangle && !InsideVerticalRectangle && !InsideOnCommonEdge;

            bool Border = (((PointX == VerticalX1 || PointX == VerticalX2) && (PointY <= VerticalY1 && PointY >= VerticalY2)) ||
                          ((PointY == VerticalY1 || PointY == VerticalY2) && (PointX >= VerticalX1 && PointX <= VerticalX2)) ||
                          ((PointX == HorizontalX1 || PointX == HorizontalX2) && (PointY <= HorizontalY1 && PointY >= HorizontalY2)) ||
                          ((PointY == HorizontalY1 || PointY == HorizontalY2) && (PointX >= HorizontalX1 && PointX <= HorizontalX2))) &&
                          !InsideOnCommonEdge;

            if (Border)
            {
                Console.WriteLine("border");
            }
            else
            {
                if (Inside)
                {
                    Console.WriteLine("inside");
                }
                else if (Outside)
                {
                    Console.WriteLine("outside");
                }
            }
        }
    }
}
