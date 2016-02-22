///<summary> 
///TITLE              Hexadecimal                 Chapter2Exercise4.cs 
///    COMMENT
///        Objective: Initialize an int variable with hexadecimal value.
///            Input: -
///           Output: -            
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>22.02.2016</datecreated>
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter2Exercise4
    {
        static void Main()
        {
            // hex type prefix 0x; value: 1 * 16^2 + 0 * 16^1 + 0 * 16^0 = 16^2 = 256
            int var1 = 0x100;

            Console.WriteLine(var1);
        }
    }
}
