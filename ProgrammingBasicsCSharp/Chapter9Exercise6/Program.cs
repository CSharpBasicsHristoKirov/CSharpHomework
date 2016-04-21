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
        /*
            Method: GreaterOrSmallerThanAdjacent(int TargetIndex, param int[] Array);

            It returns true iff the adjacent elements both have smaller
            vlues than the element with TargetIndex.
        */
        public static bool GreaterThanAdjacent(int TargetIndex, params int[] Array)
        {
            // Array must have at least one element; TargerIndex within [0, Array.Length]
            if (Array.Length < 1 || TargetIndex < 0 || TargetIndex > Array.Length - 1)
            {
                throw new System.AccessViolationException();
            }

            // special cases
            if (TargetIndex == 0)
            {
                if (Array[TargetIndex] > Array[TargetIndex + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (TargetIndex == Array.Length - 1)
            {
                if (Array[TargetIndex] > Array[TargetIndex - 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // general case
            if (Array[TargetIndex] > Array[TargetIndex - 1] && Array[TargetIndex] > Array[TargetIndex + 1])
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
            Method: FindFirstLargerThanAdjacent(param int[] Array);

            It returns the index of the first element larger 
            than its adjacent; -1 if no such element.
        */
        public static int FindFirstLargerThanAdjacent(params int[] Array)
        {
            int length = Array.Length;
            // search only elements that have two adjacent elements 
            for (int i = 1; i < length - 2; i++)
            {
                if (GreaterThanAdjacent(i, Array))
                {
                    return i;
                }
            }
            return -1;
        }


        //==========================================================
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 4, 3, 5, 6 };

            try
            {
                Console.WriteLine("The first element larger than its two adjacent:");

                int index = FindFirstLargerThanAdjacent(Array);

                Console.WriteLine("Index {0}, Value {1}", index, Array[index]);
            }
            catch (AccessViolationException)
            {
                Console.WriteLine("Target Index out of bounds or Empty Array!\n");
            }
        }
    }
}
