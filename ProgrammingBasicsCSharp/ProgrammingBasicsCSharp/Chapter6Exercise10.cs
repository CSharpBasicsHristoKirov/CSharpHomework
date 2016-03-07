/*
   <summary>     
   TITLE              Increasing order        Chapter6Exercise10.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read a number n < 20. Print a block of 
                      n x n with increasing sequence of numbers
                      of the form: If n = 3
                      1 2 3
                      2 3 4
                      3 4 5
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>06.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise10
    {
        /*
            Method: void block(int n);

            Prints a n x n block.
        */
        static void block(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0,3}", (j + i));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main()
        {
            // read input
            int n = int.Parse(Console.ReadLine());

            // print n x n block
            block(n);
        }
    }
}
