/*
   <summary>    
   TITLE              GetMax()                Chapter9Exercise2.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Implement a method that returns 
                      the input paramter with the greatest
                      value. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter9Exercise2
    {
        /*
            Method: GetMax(int a, int b);


        */
        static int GetMax(int a, int b)
        {
            return (a > b) ? a : b;
        }

        //========================================================
        static void Main()
        {
            int a = 5, b = 6;

            Console.WriteLine("The greatest between {0} and {1} is {2}", a, b, GetMax(a, b));
        }
    }
}
