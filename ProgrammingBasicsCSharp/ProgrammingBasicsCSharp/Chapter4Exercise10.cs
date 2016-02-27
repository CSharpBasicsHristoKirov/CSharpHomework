/*
   <summary>  
   TITLE              Sum of n                Chapter4Exercise10.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read the number of integers you want to sum.
                      Read them and print their sum.
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
    class Chapter4Exercise10
    {
        static void Main()
        {
            // information
            Console.WriteLine("Sum of n numbers.");

            // select the number of integers to sum
            string input1 = string.Empty;
            int numberOfTerms = 0;
            do
            {
                Console.WriteLine("How many numbers do you want to sum: ");
                input1 = Console.ReadLine();
            }
            while (!int.TryParse(input1, out numberOfTerms) || numberOfTerms <= 0);

            // read input; check input validity
            int sum = 0;
            for (int i = 0; i < numberOfTerms; i++)
            {
                Console.WriteLine("Type an integer: ");
                string input2 = Console.ReadLine();

                int term = 0;
                if (int.TryParse(input2, out term))
                {
                    sum += term;
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
