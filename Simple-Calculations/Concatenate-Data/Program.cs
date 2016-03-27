/*
  <summary>    
  TITLE              Concatenate data                  Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read first-, last- name, age, town.
                     Print the input data into single sentence.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>27.03.2016</datecreated>
*/
using System;

namespace Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.",
                               firstName, lastName, age, town);
        }
    }
}
