///<summary> 
///TITLE              Type-value match          Chapter2Exercise2.cs 
///    COMMENT
///        Objective: Select proper real type for the list of values. 
///            Input: -
///           Output: -            
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>22.02.2016</datecreated>
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter2Exercise2
    {
        static void Main()
        {
            // values that within single precision float
            float var1 = 34.567839023f;
            float var2 = 12.345f;
            float var3 = 8923.1234857f;

            // values that fit withing float, also fit within double precision floating point
            double var4 = 3456.091124875956542151256683467d; // only up to 15th digit

            // decimal representation type 
            decimal var5 = 3456.091124875956542151256683467m; // only up to 25th digit
            string var6 = "3456.091124875956542151256683467"; // just for reference all 27 digits

            Console.WriteLine("var1: {0}", var1);
            Console.WriteLine("var2: {0}", var2);
            Console.WriteLine("var3: {0}", var3);
            Console.WriteLine("var4: {0}", var4);
            Console.WriteLine("var5: {0}", var5);
            Console.WriteLine("var6: {0}", var6);
        }
    }
}
