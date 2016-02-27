/*
   <summary>  
   TITLE              Comparison               Chapter4Exercise6.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read two integers: a, b.
                      Compare them without the use
                      of the inbuilt conditional operations. 
               Input: Type first:
                      1
                      Type second:
                      2
              Output: 2 is the larger between 1 and 2.
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter4Exercise6
    {
        static void Main()
        {
            // information
            Console.WriteLine("Compare the values of two integers.");

            // read input
            Console.WriteLine("Type an integer: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Type an integer: ");
            int b = int.Parse(Console.ReadLine());

            // bitwise comparison
            int max = a - ((a - b) & ((a - b) >> 31));

            // print result
            Console.WriteLine("{0} is the larger between {1} and {2}.", max, a, b);
        }
    }
}
