/*
    TITLE         Inside The Building     Exam14042014InsideTheBuilding.cpp
    COMMENT
        Objective: https://judge.softuni.bg/Contests/9/CSharp-Basics-Exam-14-April-2014-Evening
            Input: -
           Output: -
           Author: Chris B. Kirov
             Date: 02.03.2016
*/
using System;
using System.Text;

namespace CSharpExamPractice
{
    class Exam14042014InsideTheBuilding
    {
        static string isInsideBuilding(int scaleFactor, int x, int y)
        {
            // split the figure into two rectangles
            // horizontal rectangle
            bool inHorizontal = ((x >= 0 && x <= scaleFactor * 3) &&
                                 (y >= 0 && y <= scaleFactor));

            // vertical rectangle
            bool inVertival = ((x >= scaleFactor && x <= scaleFactor * 2) &&
                               (y >= scaleFactor && y <= scaleFactor * 4));

            return (inHorizontal || inVertival) ? "inside" : "outside";
        }

        static void Main(string[] args)
        {
            // read input
            int size = int.Parse(Console.ReadLine());
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());
            int x5 = int.Parse(Console.ReadLine());
            int y5 = int.Parse(Console.ReadLine());

            // print result
            Console.WriteLine(isInsideBuilding(size, x1, y1));
            Console.WriteLine(isInsideBuilding(size, x2, y2));
            Console.WriteLine(isInsideBuilding(size, x3, y3));
            Console.WriteLine(isInsideBuilding(size, x4, y4));
            Console.WriteLine(isInsideBuilding(size, x5, y5));
        }
    }
}
