/*
   <summary>  
   TITLE               Compare and swap        Chapter5Exercise1.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a conditional expression that compares
                      two values and swaps them if the first is
                      greater than the second.
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
    class Chapter5Exercise1
    {
        static void Main()
        {
            // int lhs = 1; // no swap
            int lhs = 3;    
            int rhs = 2;
            Console.WriteLine("lhs: {0}, rhs: {1}", lhs, rhs);

            // compare and swap
            if (lhs > rhs)
            {
                Console.WriteLine("Values swapped.");
                int temp = lhs;
                lhs = rhs;
                rhs = temp;
            }

            Console.WriteLine("lhs: {0}, rhs: {1}", lhs, rhs);
        }
    }
}
