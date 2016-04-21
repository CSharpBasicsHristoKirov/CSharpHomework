/*
  <summary>    
  TITLE              Time In 15 Minutes                Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read an hour in input format (hh:mm),
                     print the hour after 15 minutes.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>05.04.2016</datecreated>
*/
using System;

namespace Time_In_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int AllInMinutes = hour * 60 + minutes + 15;

            Console.WriteLine("{0}:{1:0#}", ( AllInMinutes / 60 ) % 24, AllInMinutes % 60);
        }
    }
}
