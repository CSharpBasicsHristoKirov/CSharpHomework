/*
  <summary>    
  TITLE              Greetings by name                 Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read you name. 
                     Print a greetig inclusing your name.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>27.03.2016</datecreated>
*/
using System;

namespace Greetings_by_name
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
