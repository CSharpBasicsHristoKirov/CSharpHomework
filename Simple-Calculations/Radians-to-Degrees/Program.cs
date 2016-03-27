/*
  <summary>    
  TITLE              Angle unit convertion       Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read angle in Radians. 
                     Print in degrees. 
                     (Round to the nearest integer)
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>28.03.2016</datecreated>
*/
using System;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double deg = 180 / Math.PI * rad;
            Console.WriteLine(Math.Round(deg, 0));
        }
    }
}
