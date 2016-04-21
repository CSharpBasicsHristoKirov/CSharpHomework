/*
  <summary>    
  TITLE              Enter Even Number                 Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Check if n is prime and print:
                     "Prime"
                     "Not Prime"
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>18.04.2016</datecreated>
*/
using System;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = "Enter even number: ";
            string invalidInput = "The number is not even.";
            string wrongType = "Invalid number!";
            string success = "Even number entered: ";

            int n;
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(invalidInput);
                    }
                }
                catch 
                {
                    Console.WriteLine(wrongType);
                }
            }

            Console.WriteLine(success + n);
        }
    }
}
