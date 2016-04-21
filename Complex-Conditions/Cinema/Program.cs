/*
  <summary>    
  TITLE              Cinema                            Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read screening type, numbers of rows and columns.
                     Calculate and print profit if full house sold.
                     (with two digits after the decimal point) 
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>06.04.2016</datecreated>
*/
using System;
 
namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var ScreeningType = Console.ReadLine().ToLower();
            var RowNumber = int.Parse(Console.ReadLine());
            var ColumnNumber = int.Parse(Console.ReadLine());

            double profit = RowNumber * ColumnNumber;
            switch (ScreeningType)
            {
                case "premiere": Console.WriteLine("{0:f2} leva", profit * 12.0); return;
                case "normal": Console.WriteLine("{0:f2} leva", profit * 7.5); return;
                case "discount": Console.WriteLine("{0:f2} leva", profit * 5.0); return;
                default: return;
            }
        }
    }
}
