/*
   <summary>     
   TITLE              Max Sum Sequence         Chapter7Exercise9.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Find the sequence of elements with the maximum
                      sum.
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
    class Chapter7Exercise9
    {
        /*
            Method: maxSumSequence(arr);

            It prints the sequence with max sum and its value.
        */
        static void maxSumSequence(int[] arr)
        {
            int currentSum = 0;
            int maxSum = int.MinValue;
            int lastElementIndex = -1;

            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                currentSum += arr[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    lastElementIndex = i;
                }
                else if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }
            // print result
            Console.WriteLine("Max sum: {0}", maxSum);

            int index = lastElementIndex;
            while (maxSum > 0)
            {
                maxSum -= arr[index--];
            }
            Console.Write("{");
            for (int i = index + 1; i <= lastElementIndex; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.Write("}\n");
        }

        //==============================================================================
        static void Main()
        {
            int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            maxSumSequence(numbers);
        }
    }
}
