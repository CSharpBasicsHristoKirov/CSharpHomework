/*
   <summary>  
   TITLE             Max integer                Chapter4Exercise8.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read n integers and find the one with max value;
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
    class Chapter4Exercise8
    {
        static void Main()
        {
            // information
            int numberOfTerms = 5;
            Console.WriteLine("Find the integer with the maximum value out of " + numberOfTerms);

            // read input; check input validity
            int max = -2147483648;
            for (int i = 0; i < numberOfTerms; i++)
            {
                Console.WriteLine("Type an integer: ");
                string input = Console.ReadLine();

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
