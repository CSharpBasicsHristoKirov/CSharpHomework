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

            // 3! possible relations
            if (a >= b)
            {
                if (a >= c)
                {
                    if (b >= c)
                    {
                        Console.WriteLine("{0} >= {1} >= {2}", a, b, c);
                    }
                    else
                    {
                        Console.WriteLine("{0} >= {1} >= {2}", a, c, b);
                    }
                }
                else
                {
                     Console.WriteLine("{0} >= {1} >= {2}", c, a, b);
                }
            }
            else
            {
                if (b >= c)
                {
                    if (a >= c)
                    {
                        Console.WriteLine("{0} >= {1} >= {2}", b, a, c);
                    }
                    else
                    {
                        Console.WriteLine("{0} >= {1} >= {2}", b, c, a);
                    }
                }
                else
                {
                    Console.WriteLine("{0} >= {1} >= {2}",c ,b, a);
                } 
            }
        }
    }
}
