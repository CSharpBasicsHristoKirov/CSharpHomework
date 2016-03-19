/*
   <summary>     
   TITLE              Remove and sort         Chapter7Exercise22.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Populate an int array of n elements.
                      Remove minimal number of elements such 
                      that the array is sorted in ascending order.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>18.03.2016</datecreated>
*/
using System;
using System.Collections.Generic;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise22
    {
        /*
            Method: sortRemove(src);

            It removes minimal number of elements
            from src, so that the remaining elements
            returned in a list are in sorted order.
        */
        static List<int> sortRemove(int[] numbers)
        {
            List<int> longestSubarray = new List<int>();

            // try starting from each element of the array
            for (int i = 0; i < numbers.Length; ++i)
            {
                List<int> currentSubarray = new List<int>();

                // start the search from ith element
                currentSubarray.Add(numbers[i]);

                // look for equal or least larger in the remaining of the arrat
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // find the next least larger or equal
                    int nextElementIndex = leastLargerOrEqual(numbers, j, currentSubarray[currentSubarray.Count - 1]);

                    // if index valid (!= -1) add element with that index
                    if (nextElementIndex != -1)
                    {
                        currentSubarray.Add(numbers[nextElementIndex]);
                    }
                    else // stop the search if there is no larger or equal element than current
                    {
                        break;
                    }

                    // jump to next element
                    j = nextElementIndex;
                }

                // check is current subarray is the longest 
                if (currentSubarray.Count > longestSubarray.Count)
                {
                    longestSubarray = currentSubarray;
                }

                // stop if the number of the remaining unchecked elements smaller than the longest subarray 
                if (longestSubarray.Count >= numbers.Length - i)
                {
                    break;
                }
            }

            return longestSubarray;
        }

        //--------------------------------------------------------------------------
        /*
            Method: int index = leastLargerOrEqual(array, startIndex, referent);

            It returns the index of the least larger or equal (to referent) element. 
        */
        static int leastLargerOrEqual(int[] array, int startIndex, int referent)
        {
            int targetIndex = -1; // initial value signifies no larger element than referent exists
            int difference = int.MaxValue;

            for (int i = startIndex; i < array.Length; ++i)
            {
                // return equal
                if (array[i] == referent)
                {
                    return i;
                }

                // return least larger
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

        //--------------------------------------------------------------------------
        /*
            Method: printArray(label, arr);

            Print the array elements.
        */
        static void print(string label, int[] arr)
        {
            Console.Write(label);
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
        //=======================================================================

        static void Main()
        {
            int[] numbers = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            print("", numbers);

            // sort by removing minimum number of elements
            List <int> sorted = sortRemove(numbers);

            // convert result to array
            int[] destination = sorted.ToArray();

            print("->", destination);
        }
    }
}
