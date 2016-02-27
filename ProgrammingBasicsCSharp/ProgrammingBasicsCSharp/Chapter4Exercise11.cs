/*
   <summary>  
   TITLE              Print n numbers         Chapter4Exercise11.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Type an upper bound to the interval [1, n].
                      Print all the numbers within it on a new line.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter4Exercise11
    {
        static void Main()
        {
            // information
            Console.WriteLine("Print n numbers.");

            // select the number of integers to sum
            string input1 = string.Empty;
            int lowerBound = 1;
            int upperBound = 0;
            do
            {
                Console.WriteLine("How many numbers do you want to print: ");
                input1 = Console.ReadLine();
            }
            while (!int.TryParse(input1, out upperBound) || upperBound <= lowerBound);

            // print result
            for (int i = lowerBound; i <= upperBound; i++)
            {
                Console.Write(i + "\n");
            }
        }
    }
}
