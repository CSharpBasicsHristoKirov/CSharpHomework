/*
   <summary>    
   TITLE              Find hypotenuse          Chapter11Exercise5
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Type both catheti and find hypotenuse.
               Input: 
                      3
                      4
              Output: 5
                  
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>15.10.2016</datecreated>
*/
using System;

namespace Chapter11Exercise5
{
    class Hypotenuse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type first cathetus:");
            int side1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type second cathetus:");
            int side2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Hypotenuse is = {0}", Math.Sqrt((side1 * side1) + (side2 * side2)));
        }
    }
}
