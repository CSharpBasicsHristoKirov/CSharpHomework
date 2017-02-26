/*
   <summary>    
   TITLE              Local Max                   Chapter9Exercise5    
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Implement a method that returns whether 
                      an element at specific position is greater 
                      than the adjacent elements both have smaller
                      values than the element with TargetIndex.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>01.04.2016</datecreated>
*/
using System;

namespace Chapter9Exercise5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr= { 1, 2, 3, 4, 3, 5, 6 };
            int targetIndex = 3;

            PrintArray(arr);
            try
            {
                Console.Write("\nThe element with index {0} is: ", targetIndex);

                if (!GreaterThanNeigbouring(targetIndex, arr))
                {
                    Console.Write(" not");
                }

                Console.WriteLine(" larger than its two adjacent.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //-----------------------------------------------------------------------------

        /*
            Method: GreaterThanNeigbouring(int targetIndex, param int[] Array);
  
            It returns true iff the adjacent elements both have smaller
            values than the element with targetIndex.
        */
        public static bool GreaterThanNeigbouring(int targetIndex, params int[] arr)
        {
            // check array length, index value and their relation
            if (arr.Length < 1 || targetIndex < 0 || targetIndex > arr.Length - 1)
            {
                throw new Exception("Invalid parameters!\n");
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
        //-----------------------------------------------------------------------------

        /*
            Method: PrintArray()

        */
        static void PrintArray(int [] arr)
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
            Console.Write("}");
        }
    }
}
