/*
  <summary>    
  TITLE              Date manipulation                 Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read a date (in the format dd-MM-yyyy)
                     Print the date after 1000 days.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>28.03.2016</datecreated>
*/
using System;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string format = "dd-MM-yyyy";
            DateTime initial = DateTime.ParseExact(input, format, null);

            DateTime final = initial.AddDays(999);

            Console.WriteLine(final.ToString(format));            
        }
    }
}
