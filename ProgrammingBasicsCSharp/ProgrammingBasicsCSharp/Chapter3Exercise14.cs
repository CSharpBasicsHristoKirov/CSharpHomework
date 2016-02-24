/*
   <summary>  
   TITLE              Prime numbers           Chapter3Exercise14.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: 1. Read an integer.
                      2. Check if prime.  
               Input: Type an integer:
                      3
              Output: The number: 3 is prime.
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>24.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise14
    {
        static void Main()
        {
            // read input
            Console.WriteLine("Type an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // check if number is prime
            int length = number;
            for (int i = 2; i < length; i++)
            {
                if (number % i == 0 && number != i)
                {
                    Console.WriteLine(number + " is not prime.");
                    return;
                }
            }
            Console.WriteLine("The number: " + number + " is prime.");
        }
    }
}
