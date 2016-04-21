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
        /*
            Method: GreaterOrSmallerThanAdjacent(int TargetIndex, param int[] Array);

            It returns true iff the adjacent elements both have smaller
            vlues than the element with TargetIndex.
        */
        public static bool GreaterThanAdjacent(int TargetIndex, params int[] Array)
        {
            // Array must have at least one element; TargerIndex within [0, Array.Length]
            if (Array.Length < 1 || TargetIndex < 0 || TargetIndex > Array.Length - 1 )
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
        
        //==========================================================
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 4, 3, 5, 6 };
            int TargetIndex = 3;

            try
            {
                Console.Write("The element with index {0} is", TargetIndex);

                if (!GreaterThanAdjacent(TargetIndex, Array))
                {
                    Console.Write(" not");
                }

                Console.Write(" larger than its two adjacent");
            }
            catch (AccessViolationException)
            {
                Console.WriteLine("Target Index out of bounds or Empty Array!\n");
            }
        }
    }
}
