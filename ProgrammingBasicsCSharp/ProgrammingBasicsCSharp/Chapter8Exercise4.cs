/*
   <summary>     
   TITLE              Decimal to binary        Chapter8Exercise4.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Convert decimal to binary.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>26.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter8Exercise4
    {
        static void Main()
        {
            Console.WriteLine("Type a positive integer:");
            int n = int.Parse(Console.ReadLine());

            // test line (using C# libraries)
            Console.WriteLine("{0}(10) -> {1}(2).", n, Convert.ToString(n, 2));

            // convert by dividing by the destination base
            Console.WriteLine("{0}(10) -> {1}(2)",n , DecimalToBinary((uint) n));

            // convert by logical operations: AND with mask = 1;
            Console.WriteLine("{0}(10) -> {1}(2)", n, DecimalToBinaryBitwise(n));

        }
        //------------------------------------------------------------------

        /*
            Method: DecimalToBinary(n);

            It returns a string holding the binary representation 
            of the number passed as parameter.
        */
        static string DecimalToBinary(uint n)
        {
            if (n == 0)
            {
                return "0";
            }

            string binary = string.Empty;

            while (n > 0)
            {
                uint remainder = n % 2;
                n /= 2;

                // insert remainder in front
                binary = remainder.ToString() + binary;
            }
            return binary;
        }
        //------------------------------------------------------------------

        /*
             Method: DecimalToBinaryBitwise(n);

             It returns a string holding the binary representation 
             of the number passed as parameter.
        */
        static string DecimalToBinaryBitwise(int n)
        {
            string binary = string.Empty;

            int length = sizeof(int) * 8;
            for (int i = 0; i < length; i++)
            {
                int mask = 1;
                int valueOfLSB = (n >> i) & mask;

                binary = valueOfLSB.ToString() + binary;
            }
            return binary;
        }
    }
}
