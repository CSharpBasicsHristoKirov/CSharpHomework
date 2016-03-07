/*
   <summary>    
   TITLE              First N Fibonacci        Chapter6Exercise5.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read n; Print the first n Fibonacci numbers.  
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
    class Chapter6Exercise5
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int firstFibonacci = 0, secondFibonacci = 1;
            for (int i = 0; i < n; i++)
            {
                int current = firstFibonacci + secondFibonacci;
                Console.Write(current + " ");

                firstFibonacci = secondFibonacci;
                secondFibonacci = current;
                
                // 10 elements per line
                if (i % 10 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
