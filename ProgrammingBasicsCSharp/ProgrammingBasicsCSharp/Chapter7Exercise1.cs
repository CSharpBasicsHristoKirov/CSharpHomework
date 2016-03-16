/*
   <summary>     
   TITLE              Arrays                   Chapter7Exercise1.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Define an array of lenght / size 20 and 
                      initialize its elements with values 
                      equal to its index multiplied by 5. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>10.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise1
    {
        static void Main()
        {
            // define array of size 20
            int size = 20;
            int[] numbers = new int[size];

            // initialize elements
            int multiplier = 5;
            for (int i = 0; i < size; i++)
            {
                numbers[i] = i * multiplier; 
            }

            // print array elements
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
