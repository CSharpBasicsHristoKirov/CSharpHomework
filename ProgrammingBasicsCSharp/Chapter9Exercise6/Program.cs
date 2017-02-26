/*
   <summary>    
   TITLE              Find first Local Max            Chapter9Exercise6   
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Implement a method that returns the
                      index of the element that is greater 
                      than itsadjacent elements.
                      Return -1 to signify no such element. 
           
                    
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>01.04.2016</datecreated>
*/
using System;

namespace Chapter9Exercise6
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 3, 7, 6 };
            PrintArray(arr);

            try
            {
                Console.WriteLine("The first element larger than its two adjacent has:");

                int index = FindFirstLargerThanNeighbouring(arr);

                Console.WriteLine("Index: {0}, Value: {1}", index, arr[index]);
            }
            catch (AccessViolationException)
            {
                Console.WriteLine("Target Index out of bounds or Empty Array!\n");
            }
        }
        //-----------------------------------------------------------------------------------------------------

        /*
            Method: GreaterThanNeighbouring(int TargetIndex, param int[] Array);

            It returns true iff the adjacent elements both have smaller
            vlues than the element with TargetIndex.
        */
        public static bool GreaterThanNeighbouring(int targetIndex, params int[] arr)
        {
            // Array must have at least one element; TargerIndex within [0, Array.Length]
            if (arr.Length < 1 || targetIndex < 0 || targetIndex > arr.Length - 1)
            {
                throw new Exception("Invalid parameters!");
            }

            // special cases
            if (targetIndex == 0)
            {
                if (arr[targetIndex] > arr[targetIndex + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (targetIndex == arr.Length - 1)
            {
                if (arr[targetIndex] > arr[targetIndex - 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // general case
            if (arr[targetIndex] > arr[targetIndex - 1] && arr[targetIndex] > arr[targetIndex + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //-----------------------------------------------------------------------------------------------------

        /*
            Method: FindFirstLargerThanNeighbouring(param int[] arr);

            It returns the index of the first element larger 
            than its adjacent; -1 if no such element.
        */
        public static int FindFirstLargerThanNeighbouring(params int[] arr)
        {
            // search only elements that have two adjacent elements 
            for (int i = 1; i < arr.Length - 2; i++)
            {
                if (GreaterThanNeighbouring(i, arr))
                {
                    return i;
                }
            }
            return -1;
        }
        //-----------------------------------------------------------------------------

        /*
            Method: PrintArray()

        */
        static void PrintArray(int[] arr)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);

                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
        }
    }
}
