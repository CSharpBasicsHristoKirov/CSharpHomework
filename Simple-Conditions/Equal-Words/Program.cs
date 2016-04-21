/*
  <summary>    
  TITLE              Equal Words                       Program.cs
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

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstWord = Console.ReadLine();
            string SecondWord = Console.ReadLine();

            FirstWord = FirstWord.ToLower();
            SecondWord = SecondWord.ToLower();

            if (FirstWord == SecondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
