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
        static void Main()
        {
            Console.WriteLine("Type number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            PopulateArray(numbers, n);

            PrintArray(numbers);

            Console.WriteLine("Type number of elements to search maximum sum of: ");
            int k = int.Parse(Console.ReadLine());

            MaxSum(numbers, k);
        }

        //-------------------------------------------------------------------------------

        /*
            Method: PrintArray(arr);

        */
        static void PrintArray(int[] arr)
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
            Method: PopulateArray(arr, n);

            It generates n random ([1, 20]) array elements. 
        */
        static void PopulateArray(int[] arr, int n)
        {
            Random element = new Random();
            int minValue = 1, maxValue = 20;
            for (int i = 0; i < n; i++)
            {
                arr[i] = element.Next(minValue, maxValue);
            }
        }
        //-------------------------------------------------------------------------------

        /*
            Method: MaxSum(array, n);

            Finds and prints max sum out of n elements
            of the array.
        */
        static void MaxSum(int[] array, int n)
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
    }
}
