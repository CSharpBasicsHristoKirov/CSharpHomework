/*
   <summary>     
   TITLE              Decimal to Hexadecimal  Chapter6Exercise14.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a program that converts a number from
                      decimal to hexadecimal. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>07.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise14
    {
        static void Main()
        {
            Console.WriteLine("Type a number in decimal representation:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} in hexadecimal is {1:x}", n, n);
            Console.WriteLine("From function: {0}", DecimalToHexadecimal(n));
        }
        //-------------------------------------------------------------------------

        /*
            DecimalToHexadecimal(n);

            It returns a string representing
            the hexadecimal value of the parameter.
            Assumes parameter is positive integer.
        */
        static string DecimalToHexadecimal(int n)
        {
            if (n == 0)
            {
                return "0";
            }

            string hex = string.Empty;

            while (n > 0)
            {
                int remainder = n % 16;

                if (remainder < 10)
                {
                    hex = remainder.ToString() + hex;
                }
                else
                {
                    string symbol = string.Empty;
                    switch (remainder)
                    {
                        case 10: symbol = "A"; break;
                        case 11: symbol = "B"; break;
                        case 12: symbol = "C"; break;
                        case 13: symbol = "D"; break;
                        case 14: symbol = "E"; break;
                        case 15: symbol = "F"; break;
                    }
                    hex = symbol + hex;
                }

                // truncate LSB
                n /= 16;
            }
            return hex;
        }
    }
}
