/*
   <summary>     
   TITLE              Selection sort           Chapter7Exercise8.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Sort an array using Selection Sort algorithm.

                      Find subarray element with current min (max)
                      value and swaps it with left most element.
                      Exclude first element from next subarray and
                      repeat. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>12.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise8
    {
        /*
            Method: void swapArrayElements(ref a, ref b);

        */
        static void swapArrayElements(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //------------------------------------------------------------------------------

        /*
            Method: selectionSort(arr);

            It sorts the elements of the integer
            array passed as argument in ascending
            (descending) order using Selection Sort.
        */
        static void selectionSort(int[] arr)
        {
            int startIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                // traverse current subarray
                int maxIndex = startIndex;
                for (int j = startIndex; j < arr.Length; j++)
                {
                    // find min 
                    if (arr[j] < arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                // swap min with first element in current subarray
                swapArrayElements(ref arr[startIndex], ref arr[maxIndex]);
                // min value is in front, start next subarray from next character
                ++startIndex;
            }
        }
        //==============================================================================
        static void Main()
        {
            int[] numbers = {2, 34, -5, 6, -43, 7, 8, 4, 5};

            Console.WriteLine("Initial array elements:");
            foreach (var item in numbers)
            {
                Console.Write(item + ", ");
            }

            // sort
            selectionSort(numbers);

            // print result
            Console.WriteLine("Sorted array elements:");
            foreach (var item in numbers)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}
