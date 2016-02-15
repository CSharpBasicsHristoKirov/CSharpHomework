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
            int elem = 1;

            int length = 100;
            for (int i = 0; i < length; i++)
            {
                ++elem;
                if (i % 2 == 0)
                {
                    Console.WriteLine(elem);
                }
                else
                {
                    Console.WriteLine("-" + elem);
                }
            }
        }
    }
}