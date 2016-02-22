///<summary> 
///TITLE              Char & Unicode                 Chapter2Exercise5.cs 
///    COMMENT
///        Objective: Initialize a char variable
///                   using hex value corresponding to 
///                   the decimal value 72.
///            Input: -
///           Output: The character corresponding to 72 is: H            
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>22.02.2016</datecreated>
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter2Exercise5
    {
        static void Main()
        {
            int var1 = 72;
            // explicitly convert to character value
            char var2 = (char) 72;

            Console.WriteLine("The character corresponding to 72 is: {0}", var2);
        }
    }
}
