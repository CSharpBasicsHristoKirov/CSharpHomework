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

            Console.WriteLine("Find min / max;'q' to display result:");
            string sentinel = "q";
            while(true)
            {
                Console.WriteLine("Type a number:");
                string input = Console.ReadLine();
                
                if (input == sentinel)
                {
                    break;
                }

                int n;
                if (Int32.TryParse(input, out n))
                {
                    if (n < min)
                    {
                        min = n;
                    }

                    if (n > max)
                    {
                        max = n;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong type!");
                }
            }
            Console.WriteLine("Min: {0}\nMax: {1}", min, max);
        }
    }
}
