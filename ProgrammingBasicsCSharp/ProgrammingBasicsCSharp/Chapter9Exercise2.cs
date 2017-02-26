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
        static void Main()
        {
            int length = 3;
            int[] numbers = new int[length];
            GetInput(numbers);

            Console.WriteLine("Max = {0}", GetMax(GetMax(numbers[0], numbers[1]), numbers[2]));
        }
        //-------------------------------------------------------------------------------------

        /*
            Method: GetInput()

        */
        static void GetInput(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Type a number: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        //-------------------------------------------------------------------------------------

        /*
             Method: GetMax(int a, int b);

        */
        static int GetMax(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}
