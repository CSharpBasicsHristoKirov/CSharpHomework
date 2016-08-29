///<summary> 
///TITLE              Draw a picture          Chapter2Exercise11.cs 
///    COMMENT
///        Objective: Draw a isosceles triangle using the  [copyright sign][1].
///                   [1]:https://en.wikipedia.org/wiki/List_of_Unicode_characters
///            Input: -
///           Output: -
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>22.02.2016</datecreated>

using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter2Exercise11
    {
        static void Main()
        {
            char CopyrightSign = '\u00A9';

            // top 
            Console.WriteLine( new string(' ', 9) + CopyrightSign);

            int length = 8;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(new string(' ', 8 - i) + CopyrightSign + new string(' ', 1 + 2 * i) + CopyrightSign);
            }

            // base
            int baseLength = 19;
            for (int i = 0; i < baseLength; i++)
            {
                Console.Write(CopyrightSign);
            }

            Console.Write("\n");
        }
    }
}
