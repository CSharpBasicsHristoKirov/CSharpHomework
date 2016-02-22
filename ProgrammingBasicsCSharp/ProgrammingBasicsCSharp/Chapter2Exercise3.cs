///<summary> 
///TITLE              Precision                 Chapter2Exercise3.cs 
///    COMMENT
///        Objective: Write a program that calculates values with
///                   precision up to the 6th digit after the decimal 
///                   point.
///            Input: -
///           Output: -            
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>22.02.2016</datecreated>
using System;
using System.Text;
 

namespace ProgrammingBasicsCSharp
{
    class Chapter2Exercise3
    {
        static void Main()
        {
            // float provides 7 significant digits in total 
            float var1 = 0.000001f;
            float var2 = 0.000001f;

            float var3 = var1 + var2;
            Console.WriteLine("Addition: {0}", var3);
        }
    }
}
