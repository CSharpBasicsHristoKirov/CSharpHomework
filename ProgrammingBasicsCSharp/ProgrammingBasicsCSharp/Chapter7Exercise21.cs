/*
   <summary>     
   TITLE             Sum of k array elements  Chapter7Exercise21.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Define an int array of n values.
                      Define an int "sum" and number of elements "k".
                      Check if there is a subarray
                      of "k" elements that sum up to "sum". 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>18.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise21
    {
        static void Main()
        {
            PrintArray(arr);
            SubArraySumProblem();
        }
        //--------------------------------------------------------------------

        /*
            Data members.

        */
        // targer array
        static int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
        // target sum
        static int targetSum = 14;
        // target number of subarray elements
        static int k = 3;

        //--------------------------------------------------------------------

        /*
            Method: SubArraySumProblem();

            Dynamic programming: break it to 
            smaller subproblems by making binary
            decisions: 0, or 1, about element inclusion
            on each call, updating the current sum and index.
        */
        static void SubArraySumProblem()
        {
            int index = 0;
            int currentSum = 0;
            bool[] subArray = new bool[arr.Length];

            FindSubArray(index, currentSum, subArray);
        }
        //--------------------------------------------------------------------

        /*
            Method: FindSubArray();

            Base case: - if current sum == targer sum: print current elements.
                       - if index == arr.Length: terminate search.

            Recursive step: 
                       - do not/select element with index and do not/update the current sum; recursive call with updated current sum and index.
        */
        static void FindSubArray(int index, int currentSum, bool[] subArray)
        {
            // base case
            if (currentSum == targetSum)
            {
                if (RightNumberOfElements(subArray))
                {
                    PrintSubArray(subArray);
                }
            }
            else if (index == arr.Length)
            {
                return;
            }
            else
            {
                // recursive calls
                subArray[index] = true;
                currentSum += arr[index];
                FindSubArray(index + 1, currentSum, subArray);

                currentSum -= arr[index]; // restore previous value of the sum signifying: element not selected
                subArray[index] = false;
                FindSubArray(index + 1, currentSum, subArray);
            }
        }
        //--------------------------------------------------------------------

        /*
            Method: RightNumberOfElements();

        */
        static bool RightNumberOfElements(bool[] subArray)
        {
            int elements = 0;

            for (int i = 0; i < subArray.Length; i++)
            {
                if (subArray[i] == true)
                {
                    ++elements;
                }
            }

            if (elements <= k)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 

        //--------------------------------------------------------------------
        /*
            Method: PrintArray();

        */
        static void PrintArray(int[] array)
        {
            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);

                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
        }
        //--------------------------------------------------------------------

        /*
            Method: PrintSubArray();

        */
        static void PrintSubArray(bool[] subArray)
        {
            Console.Write("S = {0} -> yes (", targetSum);
            for (int i = 0; i < subArray.Length; i++)
            {
                if (subArray[i] == true)
                {
                    Console.Write(arr[i]);
                }

                if (subArray[i] == true && i < subArray.Length - 1)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine(" = {0})", targetSum);
        }
    }
}
