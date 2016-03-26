/*
   <summary>    
   TITLE             Sign, mantissa and exponent   Chapter8Exercise15.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Type float's sign, mantissa and exponent. 
                             
                      Bit address                    LSB
                      31  30    23 22                  0
                      -   -------- ---------------------
                      sign exponent mantissa
               Input: -
              Output: !!! Deviations in mantissa bits
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter8Exercise15
    {
        /*
            Method: extractBits(n);
        */
        static void extractBits(float n)
        {
            byte[] byteArray = BitConverter.GetBytes(n);
            int val = BitConverter.ToInt32(byteArray, 0);

            Console.OutputEncoding = Encoding.UTF8;

            int length = sizeof(int) * 8;
            for (int i = length - 1; i >= 0; i--)
            {
                if (i == 31)
                {
                    Console.Write("\nзнак: ");
                }

                if (i == 30)
                {
                    Console.Write("\nескпонента: ");
                }

                if (i == 22)
                {
                    Console.Write("\nмантиса: ");
                }
                Console.Write(val >> i & 1);
            }
            Console.WriteLine();
        }

        //==================================================
        static void Main()
        {
            float n = -27.15f; // Example Output: знак = 1, експонента = 10000011, мантиса = 10110100000000000000000.
            extractBits(n);
        }
    }
}
