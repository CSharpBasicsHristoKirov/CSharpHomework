///<summary> 
///TITLE              Odd & Even  Chapter3Exercise1.cs 
///    COMMENT
///        Objective: Write an expression that checks
///                   whether an integer value is odd
///                   or even.
///            Input: -
///           Output: 2 is even.
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>23.02.2016</datecreated>
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise1
    {
        static void Main()
        {
            int testValue = 2;

            if (testValue % 2 == 0)
            {
                Console.WriteLine(testValue + " is even.");
            }
            else
            {
                Console.WriteLine(testValue + " is odd.");
            }
        }
    }
}
