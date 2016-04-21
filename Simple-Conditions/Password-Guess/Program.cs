/*
  <summary>    
  TITLE              Passrowd Guess                    Program.cs
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

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "s3cr3t!P@ssw0rd";
            string guess = Console.ReadLine();

            if (guess == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
