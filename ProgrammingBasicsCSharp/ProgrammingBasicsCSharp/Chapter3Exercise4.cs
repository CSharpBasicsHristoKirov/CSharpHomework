///<summary> 
///TITLE              Bit position  Chapter3Exercise4.cs 
///    COMMENT
///        Objective: Write an expression that checks 
///                   if the third bit of a number 
///                   (from right to left) is 1 or 0.
///                   Use bitwise operators.
///            Input: -
///           Output: The third bit is 1.
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>23.02.2016</datecreated>

using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise4
    {
        static void Main()
        {
            // hex representation
            int testValue = 0x0111;

            // test variable
            int mask = 0x0100;

            // apply bitwise & and collect the result 
            int resultOfBitwiseAnd = testValue & mask;

            // if result 1 => bit in test value is 1
            if (resultOfBitwiseAnd != 0)
            {
                Console.WriteLine("The third bit is 1.");
            }
            else
            {
                Console.WriteLine("The third bit is 0.");
            }
        }
    }
}
