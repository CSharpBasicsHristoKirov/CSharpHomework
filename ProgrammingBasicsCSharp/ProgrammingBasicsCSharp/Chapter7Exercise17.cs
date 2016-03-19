/*
   <summary>     
   TITLE              Implement merge sort    Chapter7Exercise17.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Sort an integer array using merge sort algorithm.

                      It recursively splits the list of size n 
                      into (n) sublists (called runs) until sublist size is 1, 
                      then merges those sublists to produce a sorted list.

                      Borrowed from: https://en.wikipedia.org/wiki/Merge_sort 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>17.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise17
    {
        /*
            Method: TopDownMergeSort(A);

            Wrapper.
            Array A[] has the items to sort; 
            array B[] is a work array.
        */
        static void TopDownMergeSort(int[] A)
        {
            int[] B = new int[A.Length];
            TopDownSplitMerge(A, 0, A.Length, B);
        }
        //--------------------------------------------------------------------

        /*
            Method: TopDownSplitMerge(A, iBegin, iEnd, B);

            iBegin is inclusive; 
            iEnd is exclusive (A[iEnd] is not in the set).
        */
        static void TopDownSplitMerge(int[] A, int iBegin, int iEnd, int[] B)
        {
            if (iEnd - iBegin < 2)
            {
                return;
            }

            int iMiddle = (iEnd + iBegin) / 2;   
                       
            TopDownSplitMerge(A, iBegin, iMiddle, B);   
            TopDownSplitMerge(A, iMiddle, iEnd, B);   

            TopDownMerge(A, iBegin, iMiddle, iEnd, B);   
            CopyArray(B, iBegin, iEnd, A);               
        }
        //--------------------------------------------------------------------

        /*
            Method: TopDownMerge(A, iBegin, iMiddle, iEnd, B);

            Left half is A[iBegin :iMiddle-1].
            Right half is A[iMiddle:iEnd-1   ].
        */
        static void TopDownMerge(int[] A, int iBegin, int iMiddle, int iEnd, int[] B)
        {
            int i = iBegin, j = iMiddle;

            // While there are elements in the left or right runs...
            for (int k = iBegin; k < iEnd; k++)
            {
                // If left run head exists and is <= existing right run head.
                if (i < iMiddle && (j >= iEnd || A[i] <= A[j]))
                {
                    B[k] = A[i];
                    i = i + 1;
                }
                else {
                    B[k] = A[j];
                    j = j + 1;
                }
            }
        }
        //--------------------------------------------------------------------

        /*
            Method: CopyArray(src, iBegin, iEnd, dest);

            Copies src's elements: [iBegin, iEnd)
            into dest.  
        */
        static void CopyArray(int[] B, int iBegin, int iEnd, int[] A)
        {
            for (int k = iBegin; k < iEnd; k++)
            {
                A[k] = B[k];
            }
        }
        //--------------------------------------------------------------------

        /*
            Method: printArray(label, arr);

            It prints tha label and then the 
            elements of the array.
        */
        static void printArray(string label, int[] arr)
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
            Console.Write("}\n");
        }

        //====================================================================
        static void Main()
        {
            int[] arr = { 6, 5, 3, 1, 8, 7, 2, 4 };
            printArray("Initial array:", arr);

            TopDownMergeSort(arr);

            printArray("Ordered array:", arr);
        }
    }
}
