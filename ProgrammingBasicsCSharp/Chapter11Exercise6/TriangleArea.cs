/*
   <summary>    
   TITLE             Triangle area               Chapter11Exercise6
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Calculate triangle area from three different 
                      inputs:
                      1. Length of three sides. 
                      2. Length of a side and its height. 
                      3. Length of two sides and inbetween angle. 

                      Test with equilateral triangle 
                      with side =  1, (angle = 60 and height = 0.866);
                      (same) area: 0.4330127
               Input: -
              Output: -
                  
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>15.10.2016</datecreated>
*/
using System;

namespace Chapter11Exercise6
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            selectOperation();
        }
        //---------------------------------------------------------------------------------

        /*
            Method: selectOperation()

            It provides input interface and
            calculation options provided by
            the program.
        */
        private static void selectOperation()
        {
            Console.WriteLine("Calculate triangle area. Type 'x' to exit.");
            string sentinel = "x";

            while (true)
            {
                Console.WriteLine("Type a number to select triangle area calculation:");
                Console.WriteLine("1. Length of three sides.");
                Console.WriteLine("2. Length of a side and its height.");
                Console.WriteLine("3. Length of two sides and inbetween angle.");

                string input = Console.ReadLine();

                if (input == sentinel)
                {
                    break;
                }

                int selection = 0;

                if (int.TryParse(input, out selection))
                {
                    if (selection == 1)
                    {
                        Console.WriteLine("The area of the triangle is {0}", ReadCalculateTriangleArea1());
                    }
                    else if (selection == 2)
                    {
                        Console.WriteLine("The area of the triangle is {0}", ReadCalculateTriangleArea2());
                    }
                    else if (selection == 3)
                    {
                        Console.WriteLine("The area of the triangle is {0}", ReadCalculateTriangleArea3());
                    }
                    else
                    {
                        Console.WriteLine("No such option available!");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input format!");
                }
            }

        }
        //---------------------------------------------------------------------------------

        /*
            Method: ReadCalculateTriangleArea1()

            Reads three sides and returns the area 
            of a triangle using Heron's formula.
        */
        private static float ReadCalculateTriangleArea1()
        {
            Console.WriteLine("Type side 1:");
            float side1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Type side 2:");
            float side2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Type side 3:");
            float side3 = float.Parse(Console.ReadLine());

            // check if sides form a triangle
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                float semiperimeter = (side1 + side2 + side3) / 2.0f;
                return (float)Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
            }
            else
            {
                Console.WriteLine("No such triangle!");
                return -1;
            }
        }
        //---------------------------------------------------------------------------------

        /*
            Method: ReadCalculateTriangleArea2()

            Reads a side and the height to it and
            returns the area of a triangle.
        */
        private static float ReadCalculateTriangleArea2()
        {
            Console.WriteLine("Type side:");
            float side = float.Parse(Console.ReadLine());
            Console.WriteLine("Type heigth to typed side:");
            float height = float.Parse(Console.ReadLine());

            return side * height / 2.0f;
        }
        //---------------------------------------------------------------------------------

        /*
            Method: ReadCalculateTriangleArea3()

            Reads two sides and the angle between
            them and returns the area of the triangle.
        */
        private static float ReadCalculateTriangleArea3()
        {
            Console.WriteLine("Type side 1:");
            float side1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Type side 2:");
            float side2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Type angle (degrees) in between above sides:");
            float angle = float.Parse(Console.ReadLine());

            return side1 * side2 * (float)(Math.Sin(angle * Math.PI / 180.0)) / 2.0f;
        }
    }
}
