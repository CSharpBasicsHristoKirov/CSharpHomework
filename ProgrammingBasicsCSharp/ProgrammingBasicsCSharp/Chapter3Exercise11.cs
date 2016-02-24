/*
   <summary> 
   TITLE              Bits manipulation      Chapter3Exercise11.cs 
      COMMENT
           Objective: 1. Read an integer, read bit position.
                      2. Print the value of the bit at that position
                         in the intger.  
               Input: Type an integer:
                      1
                      Type a bit position:
                      0
              Output: The bit at position: 0 in: 1 is: 1   
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>24.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise11
    {
        static void Main()
        {
            Console.WriteLine("Type an integer: ");
            int inputVariable = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type a bit position: ");
            byte bitPosition = Convert.ToByte(Console.ReadLine());

            // find bit value by AND-ing it with a known bit and observing the result
            int testVariable = 1; // equivalent to: 00000001

            // place the test bit at the right position by shifting it to the right
            int mask = testVariable << bitPosition;

            // if AND true => bit is: 1 
            int on = 1;
            int off = 0;
            int bitValue = (inputVariable & mask) != 0 ? on : off;

            // print result
            Console.WriteLine("The bit at position: "+ bitPosition+ " in: "+ inputVariable+ " is: "+ bitValue);
        }
    }
}
