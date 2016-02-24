///<summary> 
///TITLE              Rectangle       Chapter3Exercise6.cs 
///    COMMENT
///        Objective: Write an expression that calculates
///                   the area and perimeter of a rectangle
///                   from given width: w and height: h.
///            Input: Reads two doubles as width and height.
///           Output: Area = __ arbitrary units
///                   Perimeter = __ arbitrary units
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>23.02.2016</datecreated>

using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise6
    {
        static void Main()
        {
            Console.WriteLine("Type rectangle width:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type rectangle height:");
            double height = Convert.ToDouble(Console.ReadLine());

            double rectnagleArea = width * height;
            double rectnaglePerimeter = 2 * (width + height);

            Console.WriteLine("Area = " + rectnagleArea + " arbitrary units");
            Console.WriteLine("Perimeter = " + rectnaglePerimeter + " arbitrary units");
        }
    }
}
