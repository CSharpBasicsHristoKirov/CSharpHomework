///<summary> 
///TITLE              Quoted String & Escape char Chapter2Exercise9.cs 
///    COMMENT
///        Objective: Define two strings, one of them quoted
///                   containing message, with quotes.
///            Input: -
///           Output: -
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>22.02.2016</datecreated>
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter2Exercise9
    {
        static void Main()
        {
            string var1 = "The \"use\" of quotations causes difficulties.";
            // in verbatim strings escape sequences are not processed
            string var2 = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(var1);
            Console.WriteLine(var2);
        }
    }
}
