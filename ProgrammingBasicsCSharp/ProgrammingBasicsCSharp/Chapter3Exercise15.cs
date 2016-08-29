/*
   <summary>  
   TITLE              Swap bits               Chapter3Exercise15.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: 1. Read an integer.
                      2. Swap bits at positions: 3, 4 and 5 with
                         bits at positions: 24, 25 and 26.
               Input: Type a positive integer.
              Output: 56 -> 469762048.
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>25.02.2016</datecreated>
*/
using System;
using System.Collections;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise15
    {
        static void Main()
        {
            Console.WriteLine("Type a positive integer: ");
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            // get bit pattern 
            BitArray bitPattern = new BitArray(new int[] { number });
            Reverse(bitPattern);


            for (int i = 0; i < bitPattern.Length; i++)
            {
                if (bitPattern[i] == true) Console.Write(1);
                else Console.Write(0);
            }
            Console.WriteLine();
             

            // swap pairs of bits
            int[] lowerBitsIndex = { 3, 4, 5 };
            int[] higherBitsIndex = { 23, 24, 25 };
            for (int i = 0; i < lowerBitsIndex.Length; i++)
            {
                bool temp = bitPattern[lowerBitsIndex[i]];
                bitPattern[lowerBitsIndex[i]] = bitPattern[higherBitsIndex[i]];
                bitPattern[higherBitsIndex[i]] = temp;
            }
            // get integer value of the swapped bits
            int numberWithSwappedBits = GetIntFromBitArray(bitPattern);


            Reverse(bitPattern);
            for (int i = 0; i < bitPattern.Length; i++)
            {
                if (bitPattern[i] == true) Console.Write(1);
                else Console.Write(0);
            }
            Console.WriteLine();


            Console.WriteLine("{0} -> {1}.", number, numberWithSwappedBits);
        }
        //--------------------------------------------------------------------------

        /*
           Method: getIntFromBitArray()

           It returns an integer representing
           the value of the bits stored in the
           BitArray. Assumes BitArray holds 32 bits.
        */
        static private int GetIntFromBitArray(BitArray bitPattern)
        {
            int[] array = new int[1];
            bitPattern.CopyTo(array, 0);
            return array[0];
        }
        //--------------------------------------------------------------------------

        /*
           Method: Reverse()

        */
        static private void Reverse(BitArray array)
        {
            int length = array.Length;
            int mid = (length / 2);

            for (int i = 0; i < mid; i++)
            {
                bool bit = array[i];
                array[i] = array[length - i - 1];
                array[length - i - 1] = bit;
            }
        }
    }
}
