/*
  <summary>    
  TITLE              Personal Title                    Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Print the appropriate title based on gender 
                     and age.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>06.04.2016</datecreated>
*/
using System;

namespace Personal_Title
{
    class Program
    {
        static void Main(string[] args)
        {
            float age = float.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            if (age < 16) 
            {
                if (gender == 'm')
                {
                    Console.WriteLine("Master");
                }
                else if (gender == 'f')
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if (gender == 'm')
                {
                    Console.WriteLine("Mr.");
                }
                else if (gender == 'f')
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
