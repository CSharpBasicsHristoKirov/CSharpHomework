///<summary> 
///TITLE              Within circle    Chapter3Exercise8.cs 
///    COMMENT
///        Objective: Write an expression that calculates
///                   whether a point: O(x, y) is inside a
///                   circle: K ((0, 0), 5).
///            Input: -
///           Output: Point O(4, 3) within the circle.
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>23.02.2016</datecreated>

using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise8
    {
        static void Main()
        { 
            double circleRadius = 5d;
            double coordinateX = 4d;
            double coordinateY = 3d;

            double distanceFromCenter = Math.Sqrt(coordinateX * coordinateX + coordinateY * coordinateY);

            // compare the distance of the point from the center of the circle with its radius
            if (Math.Abs(distanceFromCenter) <= circleRadius)
            {
                Console.WriteLine("Point O({0}, {1}) within the circle.", coordinateX, coordinateY); 
            }
            else
            {
                Console.WriteLine("Point O({0}, {1}) is out the circle.", coordinateX, coordinateY);
            }
        }
    }
}
