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
using System.Collections.Generic;

namespace ProgrammingBasicsCSharp
{
    class Chapter8Exercise1
    {
        /*
            Method: string intToBinary(integer);

            It returns the binary representation
            of the unsigned integer passed as argument.
        */
        static string intToBinary(int n)
        {
            string binary = string.Empty;

            int length = sizeof(int) * 8;
            for (int i = 0; i < length; i++)
            {
                int mask = 1;
                int result = (n >> i) & mask;
                binary = result.ToString() + binary;
            }
            return binary;
        }

        //--------------------------------------------------------------------------
        /*
            Method: floatToBinary(value);

            It returns the binary representation
            of the floating point number passed as argument.

            !!! Not sure if results are valid !!!
        */
        static string floatToBinary(float value)
        {
            int bitCount = sizeof(float) * 8;  
            char[] result = new char[bitCount];  
            
            int intValue = BitConverter.ToInt32(BitConverter.GetBytes(value), 0);

            for (int bit = 0; bit < bitCount; ++bit)
            {
                int maskedValue = intValue & (1 << bit);

                if (maskedValue > 0)
                    maskedValue = 1;

                result[bitCount - bit - 1] = maskedValue.ToString()[0];  
            }

            return new string(result);  
        }
        //==========================================================================

        static void Main()
        {
            int[] num = { 58, 35, 43, 251 };

            int length = num.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0} in binary is: {1}.", num[i], intToBinary(num[i]));
            }

            float n = -0.41f;
            Console.WriteLine("{0} in binary is: {1}.", n, floatToBinary(n));
        }
    }
}
