/*
   <summary>  
   TITLE             Find max                  Chapter5Exercise3.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Find the number with the maximum value. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>29.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter5Exercise3
    {

        /*
            Method: findMax(int[] numbers);

            Returns the elemenet withe maximum
            value.
        */
        static int findMax(int[] numbers)
        {
            int max = Int32.MinValue;
            foreach (int val in numbers)
            {
                if (val > max)
                {
                    max = val;
                }
            }
            return max;
        }

        static void Main()
        {
            const int size = 3;
            int[] numbers = new int[size] { -100, 100, 1000 };

            Console.WriteLine("Max: {0}", findMax(numbers));
        }
    }
}
