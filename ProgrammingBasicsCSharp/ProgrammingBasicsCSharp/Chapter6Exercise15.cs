/*
   <summary>     
   TITLE              Hexadecimal to Decimal  Chapter6Exercise15.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a program that converts a number from
                      hexadecimal to decimal. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>07.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise15
    {
        static void Main()
        {
            Console.WriteLine("Type a hexadecimal value:");
            string hex = Console.ReadLine();

            Console.WriteLine("{0} as decimal is {1}", hex, HexadecimalToDecimal(hex));
        }
        //------------------------------------------------------------------------------

        /*
           Method: HexadecimalToDecimal(string hex);

           It returns the decimal value of the parameter.
           Assumes parameter is a string stroring a hexadecimal number.
        */
        static int HexadecimalToDecimal(string hex)
        {
            int dec = 0;
            int length = hex.ToString().Length;
            for (int i = 0; i < length; i++)
            {
                int summand = 0;
                // from right to left
                switch (hex[length - i - 1])
                {
                    case '0': summand = 0; break;
                    case '1': summand = 1; break;
                    case '2': summand = 2; break;
                    case '3': summand = 3; break;
                    case '4': summand = 4; break;
                    case '5': summand = 5; break;
                    case '6': summand = 6; break;
                    case '7': summand = 7; break;
                    case '8': summand = 8; break;
                    case '9': summand = 9; break;
                    case 'A': case 'a': summand = 10; break;
                    case 'B': case 'b': summand = 11; break;
                    case 'C': case 'c': summand = 12; break;
                    case 'D': case 'd': summand = 13; break;
                    case 'E': case 'e': summand = 14; break;
                    case 'F': case 'f': summand = 15; break;
                }
                // accumulate the decimal value as number within [0,15] * 16 ^ index
                dec += summand * (int)Math.Pow(16, i);
            }
            return dec;
        }
    }
}
