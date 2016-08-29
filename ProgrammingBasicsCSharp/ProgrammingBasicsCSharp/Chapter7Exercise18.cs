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
        static void Main()
        {
            Console.WriteLine("Apply Quick sort to array of integers.");

            int[] arr = { 6, 5, 3, 1, 8, 7, 2, 4 , 30, 20, 21, 200, 100 };
            PrintArray("Initial array:", arr);

            QuicksortLomutoPartiotion(arr);

            PrintArray("Ordered array:", arr);
        }
        //--------------------------------------------------------------------

        /*
            Method quicksortLomutoPartiotion(A);

            Wrapper. A - unsorted array.
        */
        static void QuicksortLomutoPartiotion(int[] A)
        {
            int indexOfFirstElement = 0;
            int indexOfLastElement = A.Length - 1;
            Quicksort(A, indexOfFirstElement, indexOfLastElement);
        }
        //--------------------------------------------------------------------

        /*
            Method: Quicksort(A, lo, hi);

            It performs the recursive calls to the functions that implement the
            aforementioned algorithm steps.

            Complexity: (worst case) O(n^2)
        */
        static void Quicksort(int[] A, int lo, int hi)
        {
            if (lo < hi)
            {
                // actual work done
                int p = Partition(A, lo, hi);

                // recursive steps
                Quicksort(A, lo, p - 1);
                Quicksort(A, p + 1, hi);
            }
        }
        //--------------------------------------------------------------------

        /*
            Method: Partiotion(A, lo, hi);

            It chooses the last element value for referent
            and then it scans the array putting it 
            in increasing order, by swapping
            elements <= referent, with their consecutive.
            Returns the index of the last element being swapped.
        */
        static int Partition(int[] A, int lo, int hi)
        {
            int pivot = A[hi];

            int i = lo; // place for swapping

            for (int j = lo; j <= hi - 1; j++)
            {
                if (A[j] <= pivot)
                {
                    SwapElements(ref A[i], ref A[j]);
                    ++i;
                }
            }

            SwapElements(ref A[i], ref A[hi]);

            return i;
        }
        //--------------------------------------------------------------------

        /*
            Method: PrintArray(label, arr);

            It prints tha label and then the elements of the array.
        */
        static void PrintArray(string label, int[] arr)
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
            Method: SwapElements(ref a, ref b);

            It swaps the values of the two variables
            passed as parameters.
        */
        static void SwapElements(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
