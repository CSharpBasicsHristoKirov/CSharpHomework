/*
   <summary>  
   TITLE             Input format             Chapter4Exercise7.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read n integers and sum them;
                      Check input format validity.
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
    class Chapter4Exercise7
    {
        static void Main()
        {
            // information
            int numberOfTerms = 5;
            Console.WriteLine("Sum of "+ numberOfTerms + " numbers.");

            // read input; check input validity
            int sum = 0;
            for (int i = 0; i < numberOfTerms; i++)
            {
                Console.WriteLine("Type an integer: ");
                string input = Console.ReadLine();

                int term = 0;
                if (int.TryParse(input, out term))
                {
                    sum +=  term; 
                }
                else
                {
                    Console.WriteLine("Wrong input format, try again!");
                    // decrement counter
                    --i;
                }
            }

            // print result
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
