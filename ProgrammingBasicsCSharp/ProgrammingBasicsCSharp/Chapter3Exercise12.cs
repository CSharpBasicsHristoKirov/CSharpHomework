/*
   <summary> 
   TITLE              Bits manipulation      Chapter3Exercise12.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: 1. Read an integer, read bit position.
                      2. Check whether the bit at the position
                         is 1.  
               Input: Type an integer:
                      1
                      Type a bit position:
                      0
              Output: The bit at position: 0 is: 1.
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>24.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise12
    {
        static void Main()
        {
            // read input
            Console.WriteLine("Type an integer: ");
            int inputVariable = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type a bit position: ");
            int bitPosition = Convert.ToInt32(Console.ReadLine());

            // check if bit at position is 1
            int testVariable = 1; // 0000001

            // shift the LSB in 1 bitPositions to the left
            int mask = testVariable << bitPosition;

            // apply bitwise operator& to inputVariable and mask; if result: true, return: 1
            bool bitValue = (inputVariable & mask) == 1 ? true : false;

            // print result
            Console.WriteLine("v = {0}, p = {1} -> {2}.", inputVariable, bitPosition, bitValue);
        }
    }
}
