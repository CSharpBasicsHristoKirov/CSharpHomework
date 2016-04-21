/*
  <summary>    
  TITLE              Area Of Figures                   Program.cs
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

namespace Area_Of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine( Math.Round(side * side, 3));
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(width * height, 3));
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * radius * radius, 3));
            }
            else if (figure == "triangle")
            {
                double Tbase = double.Parse(Console.ReadLine());
                double Theight = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Tbase * Theight / 2.0, 3));
            }
        }
    }
}
