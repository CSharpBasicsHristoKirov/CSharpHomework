/*
   <summary>     
   TITLE             Max sum of K consecutive  Chapter7Exercise7.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Find the sum of k consecutive array elements. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>12.03.2016</datecreated>
*/
using System;
using System.Collections.Generic;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise7
    {
        /*
            Method: printArray(arr);
        */
        static void printArray(int[] arr)
        {
            Console.Write("{");
            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.Write("}\n");
        }
        //-------------------------------------------------------------------------------

        /*
            Method: void populateArray(arr, n);

            It generates n random ([1, 20]) array elements. 
        */
        static void populateArray(int[] arr, int n)
        {
            Random element = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = element.Next() % 20 + 1;
            }
        }
        //-------------------------------------------------------------------------------

        /*
            Method: maxSum(array, n);

            It prints the n elements constituting the max sum 
            and its value.
            It calculates the sum of all the consecutive 
            subarrays of size n and stores the max sum.
        */
        static void maxSum(int[] array, int n)
        {
            int maximumSum = 0;
            int startingIndex = 0;

            int length = array.Length;
            for (int i = 0; i < length - n; i++)
            {
                // sum n elements from i to i + n
                int currentSum = 0;
                for (int j = 0; j < n; j++)
                {
                    currentSum += array[i + j];
                }

                // check max sum
                if (currentSum > maximumSum)
                {
                    maximumSum = currentSum;
                    startingIndex = i;
                }
            }
            // print result
            Console.WriteLine("The maximum sum is: {0}.", maximumSum);
            Console.Write("Consisted of the elements: {");
            for (int i = startingIndex; i < n; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.Write("}\n");
        }
        //==========================================================================================

        static void Main()
        {
            Console.WriteLine("Type number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            populateArray(numbers, n);

            printArray(numbers);

            Console.WriteLine("Type number of elements to search maximum sum of: ");
            int k = int.Parse(Console.ReadLine());

            maxSum(numbers, k);
        }
    }
}
