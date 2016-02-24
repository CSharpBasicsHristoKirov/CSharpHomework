///<summary> 
///TITLE              Remainder  Chapter3Exercise2.cs 
///    COMMENT
///        Objective: Write an expression that checks
///                   whether an integer is divisible
///                   by 5 and 7 (without remainder).
///            Input: -
///           Output: 35 is divisible by 5 and 7.
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>23.02.2016</datecreated>
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise2
    {
        static void Main()
        {
            int testValue = 35;

            if (testValue % 5 == 0 && testValue % 7 == 0)
            {
                Console.WriteLine(testValue + " is divisible by 5 and 7.");
            }
            else
            {
                Console.WriteLine(testValue + " is NOT divisible by 5 and 7.");
            }
        }
    }
}
