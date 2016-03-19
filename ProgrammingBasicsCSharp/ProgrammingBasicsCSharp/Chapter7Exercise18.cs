/*
   <summary>     
   TITLE              Quick Sort              Chapter7Exercise18.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Sort an integer array using quick sort.
                        
                      Pick a pivot.(element for comparison).

                      Partition: reorder the array so that all 
                      elements with values less than the pivot 
                      come before the pivot, while all elements
                      with values greater than the pivot come 
                      after it; Not the pivot in its final position.

                      Recursively apply the above on the subarrays of
                      elements > pivot and < pivot.

                      Borrowed from: https://en.wikipedia.org/wiki/Quicksort
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>17.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise18
    {
        /*
            Method quicksortLomutoPartiotion(A);

            Wrapper. A - unsorted array.
        */
        static void quicksortLomutoPartiotion(int[] A)
        {
            int indexOfFirstElement = 0;
            int indexOfLastElement = A.Length - 1;
            quicksort(A, indexOfFirstElement, indexOfLastElement);
        }

        //--------------------------------------------------------------------
        /*
            Method: quicksort(A, lo, hi);

            It performs the recursive calls to the functions that implement the
            aforementioned algorithm steps.
        */
        static void quicksort(int[] A, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = partition(A, lo, hi);
                quicksort(A, lo, p - 1);
                quicksort(A, p + 1, hi);
            }
        }

        //--------------------------------------------------------------------
        /*
            Method: partiotion(A, lo, hi);

            Chooses a pivot (last element in the array).
            It maintains the index to put the pivot in variable
            i and each time when it finds an element less than or equal to pivot,
            this index is incremented and that element would be placed before the pivot.
        */
        static int partition(int[] A, int lo, int hi)
        {
            int pivot = A[hi];

            int i = lo; // place for swapping

            for (int j = lo; j <= hi - 1; j++)
            {
                if (A[j] <= pivot)
                {
                    swapElements(ref A[i], ref A[j]);
                    ++i;
                }
            }

            swapElements(ref A[i], ref A[hi]);

            return i;
        }

        //--------------------------------------------------------------------
        /*
            Method: printArray(label, arr);

            It prints tha label and then the elements of the array.
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

        //--------------------------------------------------------------------
        /*
            Method: swapElements(ref a, ref b);

            It swaps the values of the two variables
            passed as parameters.
        */
        static void swapElements(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //====================================================================
        static void Main()
        {
            int[] arr = { 6, 5, 3, 1, 8, 7, 2, 4 };
            printArray("Initial array:", arr);

            quicksortLomutoPartiotion(arr);

            printArray("Ordered array:", arr);
        }
    }
}
