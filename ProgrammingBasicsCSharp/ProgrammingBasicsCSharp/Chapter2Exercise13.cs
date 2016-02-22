///<summary> 
///TITLE              Swap values  Chapter2Exercise13.cs 
///    COMMENT
///        Objective: Define two integer variables,
///                   swap and print their values.
///            Input: -
///           Output: -
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>22.02.2016</datecreated>

using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter2Exercise13
    {
        static void Main()
        {
            // initial values
            int var1 = 5;
            int var2 = 10;

            Console.WriteLine("Initial values.");
            Console.WriteLine("var1: {0}", var1);
            Console.WriteLine("var2: {0}", var2);

            // swap values
            int temp = var1;
            var1 = var2;
            var2 = temp;

            // print swapped values
            Console.WriteLine("Swapped values.");
            Console.WriteLine("var1: {0}", var1);
            Console.WriteLine("var2: {0}", var2);
        }
    }
}
