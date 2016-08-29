///<summary> 
///TITLE              Digit position  Chapter3Exercise3.cs 
///    COMMENT
///        Objective: Write an expression that checks 
///                   if the third digit of a number 
///                   (from right to left) is 7.
///            Input: -
///           Output: -
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>23.02.2016</datecreated>

using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise3
    {
        static void Main()
        { 
            int testValue = 16712;

            // divide by 100 (shift two digits to the left)
            int shift_by_two_digits = 100;
            int left_shifted = testValue / shift_by_two_digits;

            // the remainder of the modulo is the third digit of testValue
            int remainder = left_shifted % 10;

            // check if equal
            int benchmark = 7;
            if (remainder == benchmark)
            {
                Console.WriteLine("The third digit from the right in: {0} is {1}.", testValue, remainder);
            }
            else
            {
                Console.WriteLine("The third digit from the right in: {0} is not 7.", testValue);
            }
        }
    }
}
