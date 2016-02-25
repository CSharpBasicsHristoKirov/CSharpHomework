/*
   <summary>  
   TITLE              Swap range of bits      Chapter3Exercise16.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Swap k adjacent bits startint at positions p and q;
                      [p, p + k] and [q, q + k], where p + k < q
               Input: - Requires proper testing!
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>25.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise16
    {
        /*
            Function: swapRangeOfBits();

            It returns the number passed by the first parameter after "range" number 
            of consecutive bits starting at positions: "positionA" and "positionB"
            have been swapped.
            Assumes positionA + range < positionB.
        */
        static int swapRangeOfBits(int number, int positionA, int positionB, int range)
        {
            // range gives the LSB number of 1 
            int testVariable = 0;
            for (int i = 0; i < range; i++)
            {
                testVariable += (int)Math.Pow(2, i);
            }

            // find first range of bits
            int mask1 = testVariable << positionA;
            int firstRangeOfBits = number & mask1;

            // find second range of bits
            int mask2 = testVariable << positionB;
            int secondRangeOfBits = number & mask2;

            // clear bits at two bit ranges
            int result = number & ~(mask1 | mask2);

            // insert second range in the position of the first and vice versa
            result |= firstRangeOfBits << positionB;
            result |= secondRangeOfBits << positionA;
            return result;
        }
         
        static void Main()
        {
            int number = 0x0011;  

            int modifiedNumber = swapRangeOfBits(number, 0, 2, 2);
            Console.WriteLine(number + " after swap: " + modifiedNumber);
        }
    }
}
