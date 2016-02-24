/*
   <summary> 
   TITLE              Bits set/reset          Chapter3Exercise13.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: 1. Read an integer, bit position, new bit value.
                      2. Modify a bit in the integer at wanted position
                         to a new value.  
               Input: Type an integer:
                      3
                      Type a bit position:
                      1
                      Type new value of bit
                      0
              Output: Modified value: 1
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>24.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise13
    {
        static void Main()
        { 
            // read input
            Console.WriteLine("Type an integer: ");
            int initialValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type bit position: ");
            int bitPosition = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type new value of bit: ");
            int newBitValue = Convert.ToInt32(Console.ReadLine());

            // modify bit at position: bitPosition in initialValue
            int modifiedValue = -1;
            int setBit = 1;
            int resetBit = 0;

            if (newBitValue == setBit)
            {
                // apply bitwise operator| between the wanted bit and the shifted 1
                modifiedValue = initialValue | (1 << bitPosition);
            }
            else if (newBitValue == resetBit)
            {
                // apply bitwise operator& between the wanted bit and the shifted, negated 1
                modifiedValue = initialValue & (~(1 << bitPosition));
            }

            // print result
            Console.WriteLine("Modified value: " + modifiedValue);
        }
    }
}
