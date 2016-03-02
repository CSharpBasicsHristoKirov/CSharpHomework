/*
   <summary>    
   TITLE              Find max                 Chapter5Exercise7.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a program that finds the integer 
                      with the maximum value.

                      Code from: Chapter4Exercise8.cs 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>29.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter5Exercise7
    {
        static void Main()
        {
            // information
            int numberOfTerms = 5;
            Console.WriteLine("Find the integer with the maximum value out of " + numberOfTerms);

            // read input
            int max = int.MinValue;
            for (int i = 0; i < numberOfTerms; i++)
            {
                Console.WriteLine("Type an integer: ");
                string input = Console.ReadLine();

                // check input validity
                int term = 0;
                if (int.TryParse(input, out term))
                {
                    if (term > max)
                    {
                        max = term;
                    }
                }
                else 
                {
                    Console.WriteLine("Wrong input format, try again!");
                    // decrement counter
                    --i;
                }
            }
            // print result
            Console.WriteLine("Max: {0}", max);
        }
    }
}
