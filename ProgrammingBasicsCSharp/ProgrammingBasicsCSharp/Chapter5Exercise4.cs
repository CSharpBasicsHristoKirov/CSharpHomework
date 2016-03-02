/*
   <summary>  
   TITLE             Sort using conditionals   Chapter5Exercise4.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Sort three number using nested conditionals.
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
    class Chapter5Exercise4
    {
        static void Main()
        {
            // read input
            Console.WriteLine("Type three integers, each on a new line: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            // sort in descending order; a will be min and c max
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            if (b > c)
            {
                int temp = b;
                b = c;
                c = temp;
            }

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine("Sorted in descending order: " + c +" "+ b +" "+ a);
        }
    }
}
