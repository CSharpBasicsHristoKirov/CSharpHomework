///<summary> 
///TITLE              Sequence   Chapter1Exercise10.cs 
///    COMMENT
///        Objective: Calculate first 100 elements of 
///                   the sequence: 2,-3,4,-5,6,-7,8...
///            Input: -
///           Output: 2, -3, 4, -5, 6, -7, 8,...-101 
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>15.02.2016</datecreated>

using System;
using System.Text;
using System.Globalization;

namespace ProgrammingBasicsCSharp
{
    class Chapter1Exercise10
    {
        static void Main(string[] args)
        {
            // value of current element
            int element = 1;

            // number of elements to be displayed
            int n = 100;
            for (int i = 0; i < n; i++)
            {
                ++element;
                if (i % 2 == 0)
                {
                    Console.Write(element);
                }
                else
                {
                    // insert a '-' character in front of every odd element
                    Console.Write("-" + element);
                }

                // separate elements with comma and empty space
                if (i < n - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}