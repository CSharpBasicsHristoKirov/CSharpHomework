/*
   <summary>     
   TITLE              Binary to decimal/hexadecimal   Chapter8Exercise2.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Convert binary strings to hex and decimal.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>26.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter8Exercise2
    {
        static void Main()
        {
            // Console.WriteLine("Type a binary string:");
            // string binary = Console.ReadLine();
            string binary = "1111010110011110";

            Console.WriteLine("{0}(2) -> {1}(10), {2}(16)",
                               binary, BinaryToDecimal(binary), BinaryToHexadecimal(binary));
        }
        //--------------------------------------------------------------------------------

        /*
            Method: BinaryToHex(binaryString);

            It converts the string parameter consisted
            of binary represented number to its decimal
            representation.
        */
        static int BinaryToDecimal(string binary)
        {
            int dec = 0;
            int length = binary.Length;
            for (int i = 0; i < length; i++)
            {
                if (binary[i] == '1')
                {
                    dec += (int)Math.Pow(2, length - 1 - i);
                }
            }
            return dec;
        }
        //--------------------------------------------------------------------------------

        /*
           Method: DecimalToHexadecimal(n);

           It returns a string representing
           the hexadecimal value of the int parameter.
       */
        static string DecimalToHexadecimal(int n)
        {
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
        //--------------------------------------------------------------------------------

        /*
            Method: BinaryToHexadecimal(binaryString);

            It returns a string representing the hex value of the
            input string parameter.
        */
        static string BinaryToHexadecimal(string binaryString)
        {
            return DecimalToHexadecimal(BinaryToDecimal(binaryString));
        }
    }
}
