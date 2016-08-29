///<summary> 
///TITLE              Boolean type      Chapter2Exercise6.cs 
///    COMMENT
///        Objective: Initialize a bool variable
///                   isMale depending on your sex;
///            Input: -
///           Output: isMale: True
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>22.02.2016</datecreated>
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter2Exercise6
    {
        static void Main()
        {
            Nullable<bool> isMale = null;

            isMale = bool.Parse(Console.ReadLine()); 

            Console.Write("isMale: ");
            Console.WriteLine(isMale.ToString() ?? "Unspecified");
        }
    }
}
