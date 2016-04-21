/*
  <summary>    
  TITLE              Fruit Or Vegetable             Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read the product. 
                     Print "fruit" or "vetetable" if it matches
                     in the listed, otherwise print "unknown".
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>06.04.2016</datecreated>
*/
using System;

namespace Fruit_Or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            switch (product)
            {
                case "banana": case "apple": case "kiwi": case "cherry": case "lemon": case "grapes":
                {
                    Console.WriteLine("fruit");
                    return;
                }
                case "tomato": case "cucumber": case "pepper": case "carrot": // isn't tomato a fruit ?
                {
                    Console.WriteLine("vegetable");
                    return;
                }
                default:
                {
                    Console.WriteLine("unknown");
                    return;
                }
            }
        }
    }
}
