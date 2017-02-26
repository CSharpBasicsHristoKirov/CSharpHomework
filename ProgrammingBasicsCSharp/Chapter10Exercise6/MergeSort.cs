/*
   <summary>    
   TITLE              Merge Sort                 Chapter10Exercise6
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Implement Merge Sort algorithm.

                      Divide recursively the initial array down to size 1.
                      Compare pair of same size (till size becomes initial array size /2)
                      adjacent subarrays elements and put them in order.
               Input: {3, 4, 1, 5, 50, 200, 150, 11}
              Output: {1, 3, 4, 5, 11, 50, 150, 200}
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>12.10.2016</datecreated>
*/
using System;

namespace Chapter10Exercise6
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 1, 5, 50, 200, 150, 11 };
            PrintArray(arr, "Unsorted array.");
            SortArray(ref arr);
            PrintArray(arr, "Sorted array.");
        }
        //----------------------------------------------------------

        /*
            Method: SortArray(int[] arr)

        */
        private static void SortArray(ref int[] arr)
        {
            int[] workingArray = new int[arr.Length];
            CopyArray(arr, workingArray);
            int iBegin = 0;
            int iEnd = arr.Length;
            MergeSortTopDownSplit(ref arr, iBegin, iEnd, ref workingArray);
        }
        //----------------------------------------------------------

        /*
            Method: MergeSort(arr, 0, arr.Length);

        */
        private static void MergeSortTopDownSplit(ref int[] arr, int iBegin, int iEnd, ref int[] working)
        {
            if (iEnd - iBegin < 2)
            {
                return;
            }

            int iMiddle = (iBegin + iEnd) / 2;
            // slpit the left half
            MergeSortTopDownSplit(ref working, iBegin, iMiddle, ref arr); // notice first and last arguments are switched
            // split the right half
            MergeSortTopDownSplit(ref working, iMiddle, iEnd, ref arr);
            // sort & merge 
            Merge(ref arr, iBegin, iMiddle, iEnd, ref working);
        }
        //----------------------------------------------------------

        /*
            Method: Merge(arr, iBegin, iMiddle, iEnd, working);

        */
        private static void Merge(ref int[] arr, int iBegin, int iMiddle, int iEnd, ref int[] working)
        {
            // "working" array contains the split pairs of subarrays

            int i = iBegin;  // index for left half
            int j = iMiddle; // index for right half

            // index for the sorted array
            for (int k = iBegin; k < iEnd; k++)
            {
                /* next element in the sorted array is from the left half if: there are still elements in the left half 
                   AND there are no elements in the right half OR left element <= rigth element */
                if (i < iMiddle && (j >= iEnd || working[i] <= working[j]))
                {
                    arr[k] = working[i];
                    i = i + 1;
                }
                else
                {
                    arr[k] = working[j];
                    j = j + 1;
                }
            }
        }
        //----------------------------------------------------------

        /*
            Method: CopyArray(int[] src, int[] dest)

        */
        private static void CopyArray(int[] src, int[] dest)
        {
            for (int i = 0; i < src.Length; i++)
            {
                dest[i] = src[i];
            }
        }
        //----------------------------------------------------------

        /*
            Method: PrintArray()

        */
        private static void PrintArray(int[] arr, string label = "")
        {
            Console.WriteLine(label);
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
        }
    }
}
