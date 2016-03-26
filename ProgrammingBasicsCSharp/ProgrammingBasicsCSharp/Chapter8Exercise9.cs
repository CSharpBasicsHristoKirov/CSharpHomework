/*
   <summary>    
   TITLE              Binary to hexadecimal    Chapter8Exercise9.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Binary to hexadecimal.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>26.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter8Exercise9
    {
        /*
            Method: int dec = binaryToDecimal(binary);

            It converts the string parameter consisted
            of binary represented number to decimal
            representation.
        */
        static int binaryToDecimal(string binary)
        {
            int dec = 0;

            // sum from right to left
            int length = binary.Length;
            for (int i = length - 1, exp = 0; i >= 0; --i, ++exp)
            {
                // accumulate the sum of the set bits
                if (binary[i] == '1')
                {
                    // raise the base (i.e. 2) by the power of the bit position
                    dec += (int)Math.Pow(2, exp);
                }
            }
            return dec;
        }

        //------------------------------------------------------------------------------
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

        //------------------------------------------------------------------------------
        /*
            Method: string hex = binaryToHexadecimal(binaryString);

            It returns a string representing the binary value of the
            input parameter.

            It successively converts binary -> decimal -> hex.
        */
        static string binaryToHexadecimal(string binaryString)
        {
            return decimalToHexadecimal(binaryToDecimal(binaryString));
        }

        //==============================================================================

        static void Main()
        {
            Console.WriteLine("Type a number in binary representation:");
            string binary = Console.ReadLine();

            Console.WriteLine("{0}(2) -> {1}(16)", binary, binaryToHexadecimal(binary));
        }
    }
}
