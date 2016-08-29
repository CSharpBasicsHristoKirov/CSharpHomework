/*
   <summary>     
   TITLE              Hex to decimal and binary  Chapter8Exercise3.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Convert hexadecimal to decimal and binary.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>26.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter8Exercise3
    {
        static void Main()
        {
            string[] hex = { "2A3E", "FA", "FFFF", "5A0E9" };

            int length = hex.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0,-10}(16) -> {1,-10}(10), {2,-10}(2)",
                                   hex[i], HexadecimalToDecimal(hex[i]), HexadecimalToBinary(hex[i]));
            }
        }
        //---------------------------------------------------------------------------------------

        /*
            Method: HexadecimalToDecimal(string hex);

            It returns the decimal value of the parameter
            holding the string hexadecimal value of a number.
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
                // accumulate the decimal value as number within [0, 15] * 16 ^ index
                dec += summand * (int)Math.Pow(16, i);
            }
            return dec;
        }
        //---------------------------------------------------------------------------------------

        /*
            Method: DecimalToBinary(n);

            It returns a string holding the binary representation 
            of the number passed as parameter.
        */
        static string DecimalToBinary(int n)
        {
            string binary = string.Empty;
            while (n > 0)
            {
                int remainder = n % 2;
                n /= 2;

                // insert remainder in front
                binary = remainder.ToString() + binary;
            }
            return binary;
        }
        //---------------------------------------------------------------------------------------

        /*
            Method: HhexadecimalToBinary(n);

            It returns a string holding the binary representation 
            of the hex passed as parameter.
        */
        static string HexadecimalToBinary(string hex)
        {
            return DecimalToBinary(HexadecimalToDecimal(hex));
        }
    }
}
