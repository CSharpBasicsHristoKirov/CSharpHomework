/*
  <summary>    
  TITLE              Square area                       Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read side square. Print area of square.  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>27.03.2016</datecreated>
*/
using System;

namespace Square_Area2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Square = ");
            Console.WriteLine(area);
        }
    }
}
