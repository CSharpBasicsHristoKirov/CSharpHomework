///<summary> 
///TITLE              Type-value match    Chapter2Exercise1.cs 
///    COMMENT
///        Objective: Select proper integer type for the list of values. 
///            Input: -
///           Output: -            
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>22.02.2016</datecreated>
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter2Exercise1
    {
        static void Main()
        { 
            ushort var1 = 52130;             // [0, 65535]
            sbyte var2 = -115;               // [-128, 127] 
            int var3 = 4825932;              // [-2147483648, 2147483647]
            byte var4 = 97;                  // [0, 255]
            short var5 = -10000;             // [-32768, 32767]
            short var6 = 20000;              // [-32768, 32767]
            byte var7 = 224;                 // [0, 255]
            int var8 = 970700000;            // [-2147483648, 2147483647]
            byte var9 = 112;                 // [0, 255]
            sbyte var10 = -44;               // [-128, 127]
            int var11 = -1000000;            // [-2e+32, 2e+32 - 1]
            short var12 = 1990;              // [-32768, 32767]
            long var13 = 123456789123456789; // [-2e+64, 9e+64 - 1]

            Console.WriteLine("Check stored values: ");
            Console.WriteLine("var1: {0}", var1);
            Console.WriteLine("var2: {0}", var2);
            Console.WriteLine("var3: {0}", var3);
            Console.WriteLine("var4: {0}", var4);
            Console.WriteLine("var5: {0}", var5);
            Console.WriteLine("var6: {0}", var6);
            Console.WriteLine("var7: {0}", var7);
            Console.WriteLine("var8: {0:N}", var8);
            Console.WriteLine("var9: {0}", var9);
            Console.WriteLine("var10: {0}", var10);
            Console.WriteLine("var11: {0}", var11);
            Console.WriteLine("var12: {0}", var12);
            Console.WriteLine("var13: {0:N}", var13);
        }
    }
}
