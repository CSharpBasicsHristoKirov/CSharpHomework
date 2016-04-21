/*
  <summary>    
  TITLE              Excellent Result                  Program.cs
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

namespace Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            double ExcellentGrade = 5.50;
            if (grade >= ExcellentGrade)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
