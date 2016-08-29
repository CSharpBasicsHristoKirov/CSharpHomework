/*
   <summary>  
   TITLE              Circle Area & Perimeter  Chapter4Exercise2.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read the radius of a circle as a floating
                      point number and print its area and length.
               Input: 5.5
              Output: Area of circle with radius: 5.50 is: 95.03au.
                      Perimeter of circle with radius: 5.50 is: 34.56au.
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter4Exercise2
    {
        static void Main()
        {
            // read & parse input
            Console.WriteLine("Type a radius of a circle:");
            double r = double.Parse(Console.ReadLine());

            // print area & length
            Console.WriteLine("Area of circle with radius: {0:F2} is: {1:F2} [au^2].", r, (Math.PI * r * r));
            Console.WriteLine("Perimeter of circle with radius: {0:F2} is {1:F2} [au].", r, (2 * Math.PI * r));
        }
    }
}
