/*
   <summary>    
   TITLE             Decimal to hexadecimal     Chapter8Exercise6.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Convert a decimal to hexadecimal. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>26.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter8Exercise6
    {
        /*
          Method: hex = decimalToHexadecimal(n);

          It returns a string representing
          the hexadecimal value of the parameter.
        */
        static string decimalToHexadecimal(int n)
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
        //============================================================================

        static void Main()
        {
            Console.WriteLine("Type a positive integer:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}(10) -> {1:x}(16)", n, n);
            Console.WriteLine("{0}(10) -> {1}(16)", n, decimalToHexadecimal(n));
        }
    }
}
