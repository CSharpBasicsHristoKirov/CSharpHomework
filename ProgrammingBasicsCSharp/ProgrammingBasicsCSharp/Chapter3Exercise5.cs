///<summary> 
///TITLE              Trapezium area  Chapter3Exercise5.cs 
///    COMMENT
///        Objective: Write an expression that calculates
///                   the area of a trapezium from given
///                   two bases: a, b and height: h.
///            Input: -
///           Output: Area = 22.5 arbitrary units
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>23.02.2016</datecreated>

using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise5
    {
        static void Main()
        {
            // trapezium parameters
            float baseA = 10;
            float baseB = 5;
            float height = 3;

            float trapeziumArea = ((baseA + baseB) / 2) * height;

            Console.WriteLine("Area: " + trapeziumArea + " arbitrary units");
        }
    }
}
