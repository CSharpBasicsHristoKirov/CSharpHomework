/*
  <summary>    
  TITLE              Numbers to Text                   Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Convert an integer to its name.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>05.04.2016</datecreated>
*/
using System;

namespace Number_To_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            string name = string.Empty;
            switch (number)
            {
                case 0: name = "zero"; break;
                case 1: name = "one"; break;
                case 2: name = "two"; break;
                case 3: name = "three"; break;
                case 4: name = "four"; break;
                case 5: name = "five"; break;
                case 6: name = "six"; break;
                case 7: name = "seven"; break;
                case 8: name = "eight"; break;
                case 9: name = "nine"; break;
                default: name = "number too big"; break;
            }
            Console.WriteLine(name);
        }
    }
}
