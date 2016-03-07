/*
   <summary>    
   TITLE              Find min & max           Chapter6Exercise3.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read a numbers. 
                      Print min and max.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>05.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise3
    {
        static void Main()
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            Console.WriteLine("How many number do you want to type:");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Type a number:");
                int n = int.Parse(Console.ReadLine());

                if (n < min)
                {
                    min = n;
                }

                if (n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine("Min: {0}\nMax: {1}", min, max);
        }
    }
}
