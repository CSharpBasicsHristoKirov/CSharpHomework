/*
  <summary>    
  TITLE              Numbers In Range                  Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>18.04.2016</datecreated>
*/
using System;

namespace Numbers_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = "Enter a number in the range [1...100]:";
            string errorMessage = "Invalid number!";
            string validMessage = "The number is: ";

            while (true)
            {
                Console.Write(prompt);
                int n = int.Parse(Console.ReadLine());

                if (n < 1 || n > 100)
                {
                    Console.WriteLine(errorMessage);
                }
                else
                {
                    Console.WriteLine("{0}{1}", validMessage, n);
                    break;
                }
            }
        }
    }
}
