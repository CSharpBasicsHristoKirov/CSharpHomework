/*
   <summary>     
   TITLE              Find subarray of increasing elements    Chapter7Exercise6.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Extract the longest subarray consisted of
                      (not necessary adjacent) increasing (with +1) elements.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>11.03.2016</datecreated>
*/
using System;
using System.Collections.Generic;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise6
    {
        /*
            Method: int index = leastLarger(array, startIndex, referent);

            It returns the index to the element larger than the referent, but 
            with the smallest difference.
        */
        static int leastLarger(int[] array, int startIndex, int referent)
        {
            int targetIndex = -1; // initial value signigies no larger element than referent exist
            int difference = int.MaxValue;
            for (int i = startIndex; i < array.Length; ++i)
            {
                if (array[i] > referent)
                {
                    int currentDifference = array[i] - referent;
                    if (currentDifference < difference)
                    {
                        targetIndex = i;
                        difference = currentDifference;
                    }
                }
            }
            return targetIndex;
        }
        //==========================================================================================

        static void Main()
        {
            int[] numbers = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
            List<int> longestSubarray = new List<int>();

            for (int i = 0; i < numbers.Length; ++i)
            {
                List<int> currentSubarray = new List<int>();
                currentSubarray.Add(numbers[i]);

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // find the least larger than the last element of the current subarray
                    int nextElementIndex = leastLarger(numbers, j, currentSubarray[currentSubarray.Count - 1]);
                    if (nextElementIndex > 0)
                    {
                        currentSubarray.Add(numbers[nextElementIndex]);
                    }
                    else // there is no larger element than current
                    {
                        break;
                    }
                }
                // check is current subarray is the longest 
                if (currentSubarray.Count > longestSubarray.Count)
                {
                    longestSubarray = currentSubarray;
                }
                // the number of the remaining unchecked elements smaller than the longest subarray 
                if (longestSubarray.Count >= numbers.Length - i)
                {
                    break;
                }
            }
            // print elements
            foreach (var item in longestSubarray)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}
