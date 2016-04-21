/*
  <summary>    
  TITLE              Fruit Shop                        Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read the product, quantity and day of the week.
                     Print the cost (up to two digits after the decimal point).
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>06.04.2016</datecreated>
*/
using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day =  Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            switch (day)
            {
                case "monday": case "tuesday": case "wednesday": case "thursday": case "friday":
                {
                    switch (fruit)
                    {
                        case "banana": Console.WriteLine("{0:f2}", quantity * 2.50); return;
                        case "apple": Console.WriteLine("{0:f2}", quantity * 1.20); return;
                        case "orange": Console.WriteLine("{0:f2}", quantity * 0.85); return;
                        case "grapefruit": Console.WriteLine("{0:f2}", quantity * 1.45); return;
                        case "kiwi": Console.WriteLine("{0:f2}", quantity * 2.70); return;
                        case "pineapple": Console.WriteLine("{0:f2}", quantity * 5.50); return;
                        case "grapes": Console.WriteLine("{0:f2}", quantity * 3.85); return;
                        default: Console.WriteLine("error"); return;
                    }
                }
                case "saturday": case "sunday":
                {
                    switch (fruit)
                    {
                        case "banana": Console.WriteLine("{0:f2}", quantity * 2.70); return;
                        case "apple": Console.WriteLine("{0:f2}", quantity * 1.25); return;
                        case "orange": Console.WriteLine("{0:f2}", quantity * 0.90); return;
                        case "grapefruit": Console.WriteLine("{0:f2}", quantity * 1.60); return;
                        case "kiwi": Console.WriteLine("{0:f2}", quantity * 3.00); return;
                        case "pineapple": Console.WriteLine("{0:f2}", quantity * 5.60); return;
                        case "grapes": Console.WriteLine("{0:f2}", quantity * 4.20); return;
                        default: Console.WriteLine("error"); return;
                    }
                }
                default:
                {
                    Console.WriteLine("error"); return;
                }
            }
        }
    }
}
