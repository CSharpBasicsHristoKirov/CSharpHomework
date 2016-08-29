/*
   <summary>     
   TITLE             Int and float to binary   Chapter8Exercise1.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Convert integers and floating point numbers
                      to binary strings.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>25.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter8Exercise1
    {
        static void Main()
        {
            uint[] num = { 58, 35, 43, 251 };

            int length = num.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0} in binary is: {1}, {2}, {3}.",
                                 num[i], DecimalToBinary(num[i]), ConvertNumberBase(num[i].ToString(), 10, 2), DecimalToBinaryAlgebraic(num[i]));
            }

            float n = -0.41f;
            Console.WriteLine("{0} in binary is: {1}.", n, FloatToBinary(n));
        }
        //--------------------------------------------------------------------------

        /*
            Method: DecimalToBinary(integer);

            It returns the binary representation
            of the unsigned integer passed as argument.

            By using bitwise operations.
        */
        static string DecimalToBinary(uint n)
        {
            string binary = string.Empty;

            int length = sizeof(int) * 8;
            for (int i = 0; i < length; i++)
            {
                uint mask = 1;
                uint result = (n >> i) & mask;
                binary = result.ToString() + binary;
            }
            return binary;
        }
        //--------------------------------------------------------------------------

        /*
            Method: DecimalToBinaryAlgebraic(uint n)

            It returns the binary representation
            of the unsigned integer passed as argument.

            By using algebraic operations.
        */
        static string DecimalToBinaryAlgebraic(uint n)
        {
            string result = string.Empty;

            while (n > 0)
            {
                uint remainder = n % 2;
                n /= 2;

                result = remainder + result;
            }

            return result;
        }
        //--------------------------------------------------------------------------

        /*
            Method: FloatToBinary(value);

            It returns the binary representation
            of the floating point number passed as argument.
        */
        static string FloatToBinary(float value)
        {
            int bitCount = sizeof(float) * 8;
            char[] result = new char[bitCount];

            int intValue = BitConverter.ToInt32(BitConverter.GetBytes(value), 0);

            for (int bit = 0; bit < bitCount; ++bit)
            {
                int maskedValue = intValue & (1 << bit);

                if (maskedValue > 0)
                { 
                    maskedValue = 1;
                }

                result[bitCount - bit - 1] = maskedValue.ToString()[0];
            }

            // set the sign bit
            result[0] = (result[0] == '-') ? '1' : '0';

            return new string(result);
        }
        //--------------------------------------------------------------------------

        /*
            Method: ConvertIntegerBase(number, fromBase , toBase)

            Supported bases: 2, 8, 10, 16.

            Two cascade convertions:

            from string to integer, using fromBase
            from integer to string in base: toBase.
        */
        static string ConvertNumberBase(string number, int fromBase, int toBase)
        {
            return Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
        }
    }
}
