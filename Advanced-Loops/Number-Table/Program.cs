/*
  <summary>    
  TITLE              Number Table                      Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Read n. Print a table of numbers in the 
                     following pattern: For n = 3:
                     1 2 3
                     2 3 2
                     3 2 1
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>18.04.2016</datecreated>
*/
using System;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool equal = false;
            int initial = 1;
            for (int i = 1; i <= n; i++)
            {
                // value of first row element
                int current = initial;
                for (int j = 1; j <= n; j++)
                {
                    // increment till element equal to n and then decrement till end of row
                    if (current == n)
                    {
                        equal = true;
                    }

                    Console.Write(current + " ");

                    if (!equal)
                    {
                        current++;
                    }
                    else
                    {
                        current--;
                    }
                }
                Console.WriteLine();
                initial++;

                // reset for the next row
                equal = false;
            }
        }
    }
}
