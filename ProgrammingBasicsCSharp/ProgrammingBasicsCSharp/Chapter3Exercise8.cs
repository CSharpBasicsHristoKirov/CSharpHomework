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
            double circleRadius = 5.0f;
            double coordinateX = 4f;
            double coordinateY = 3f;

            double distanceFromOrigin = Math.Sqrt(coordinateX * coordinateX + coordinateY * coordinateY);

            if (distanceFromOrigin <= circleRadius)
            {
                Console.WriteLine("Point O(" + coordinateX + ", " + coordinateY + ") within the circle.");
            }
            else
            {
                Console.WriteLine("Point O(" + coordinateX + ", " + coordinateY + ") out the circle.");
            }
        }
    }
}
