/*
   <summary>  
   TITLE              Swap bits               Chapter3Exercise15.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: 1. Read an integer.
                      2. Swap bits at positions: 3, 4 and 5 with
                         bits at positions: 24, 25 and 26.
               Input: Type an integer:
                      117440512  // 0x07000000
              Output: 117440512 after swapping: 0 
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>25.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise15
    {
        /*
            Function: findBitValue();

            Returns the value of the bit in integer passed 
            as first parameter, at position specified by
            the second parameter.
        */
        static public int findBitValue(int number, int atPosition)
        {
            int testVariable = 1; // 00000001
            int mask = testVariable << atPosition;

            int bitValue = (mask & number) == 1 ? 1 : 0;  

            return bitValue;
        }

        /*
            Function: resetBit();

            It returns the value passed by the first 
            parameter after a bit at position specified
            by the second parameter has been reset (= 0). 
        */
        static public int resetBit(int number, int atPosition)
        {
            int testVariable = 1;
            int mask = testVariable << atPosition;
            int modifiedNumber = number & ~(mask);
            return modifiedNumber;
        }

        /*
            Function: modifyBit();

            It returns the value passed by the first parameter after
            a bit at position specified by the second parameter has
            been modified to a new value specified by the third parameter.
            Assumes that bits to be modified are reset (= 0).
        */
        static public int modifyBit(int number, int atPosition, int newBitValue)
        {
            int testVariable = 1;
            int mask = testVariable << atPosition;
            int modifiedNumber = number | mask;
            return modifiedNumber;
        }

        static void Main()
        {
            Console.WriteLine("Type an int:");
            int inputVariable = Convert.ToInt32(Console.ReadLine());

            // swap bits
            int number = inputVariable;
            // exrtact bits from position: 3, 4, 5 and 24, 25, 26
            const int arraySize = 6;
            int[] bitPositions = new int[arraySize] { 3, 4, 5, 24, 25, 26 };
            int[] bitValues = new int[arraySize];

            int length = arraySize;
            for (int i = 0; i < length; i++)
            {
                bitValues[i] = findBitValue(number, bitPositions[i]);
            }

            // reset bits at the position const int arraySize = 6;
            for (int i = 0; i < length; i++)
            {
                number = resetBit(number, bitPositions[i]);
            }

            // reasign new values to the reset bits
            int[] reversedBitPositions = new int[arraySize] { 24, 25, 26, 3, 4, 5 };
            for (int i = 0; i < length; i++)
            {
                number = modifyBit(number, reversedBitPositions[i], bitValues[i]);
            }

            // print result
            Console.WriteLine(inputVariable + " after swapping: " + number);
        }
    }
}
