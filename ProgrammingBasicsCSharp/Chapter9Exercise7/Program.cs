/*
   <summary>    
   TITLE              Print digits in reverse order Chapter9Exercise7  
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Implement a method that prints the digits 
                      of its input parameter in reversed order.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>01.04.2016</datecreated>
*/
using System;

namespace Chapter9Exercise7
{
    public class Program
    {
        /*
            Method: PrintDigitsInReverseOrder(int n);

        */
        public static void PrintDigitsInReverseOrder(int n)
        {
            while (n != 0)
            {
                int LastDigit = n % 10;

                Console.Write(LastDigit);

                n /= 10;
            }
            Console.WriteLine();
        }

        //==========================================================
        static void Main(string[] args)
        {
            int n = 256;

            PrintDigitsInReverseOrder(n);
        }
    }
}
