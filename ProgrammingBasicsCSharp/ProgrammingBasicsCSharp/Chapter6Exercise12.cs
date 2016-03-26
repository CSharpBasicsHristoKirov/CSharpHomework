/*
   <summary>     
   TITLE              Decimal to binary       Chapter6Exercise12.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a program that converts a number from
                      decimal to binary representation.
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
    class Chapter6Exercise12
    {
        /*
            Method: string binaryRepresentation = decimalToBinary(n);

            It returns a string holding the binary representation 
            of the number passed as parameter.
        */
        static string decimalToBinary(int n)
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
        //=================================================================================

        static void Main()
        {
            Console.WriteLine("Type a positive integer:");
            int n = int.Parse(Console.ReadLine());

            // Console.WriteLine("{0}(10) -> {1}(2).", n, Convert.ToString(n, 2));
            Console.WriteLine("{0}(10) -> {1}(2)", decimalToBinary(n));
        }
    }
}
