/*
   <summary>     
   TITLE              Binary Search           Chapter7Exercise16.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Implement binary search and check its 
                      optimal applicability conditions.

                      Compares the target value to the midpoint of the array;
                      if they are not equal, the lower or upper half of the 
                      array is eliminated depending on the result and the
                      search is repeated until the position of the target
                      value is found.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>16.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise16
    {
        static void Main()
        {
            // define an array
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 , 9 };
            PrintArray("Array of sorted elements:", arr);

            // read a search target
            Console.WriteLine("Type a target to seach for:");
            int target = int.Parse(Console.ReadLine());
            int targetIndex = BinarySearch(arr, target);

            // print result
            Console.Write("Target");
            if (targetIndex == -1)
            {
                Console.Write(" not");
            }
            else
            {
                Console.Write(" {0} ", arr[targetIndex]);
            }
            Console.Write(" found.\n");
        }
        //---------------------------------------------------------------

        /*
            Method: BinarySeach(arr, target);

            It searches for the the target
            element passed as second parameter
            within the (sorted) array
            passed as first parameter.

            It returns the index of the found element
            or -1 to signify not such element in the array.

            Complexity: O(log(n))
        */
        static int BinarySearch(int[] arr, int target)
        {
            int index = -1;
            // indexes of the searching interval 
            int start = 0, end = arr.Length - 1;

            // search till interval length is > 0
            while (start <= end)
            {
                // start from the element in the middle
                int middle = (start + end) / 2;

                // if this is the wanted return its index
                if (arr[middle] == target)
                {
                    return middle;
                }
                else if (arr[middle] < target) // if middle element smaller than value of target
                {
                    // set the new searching interval to be [middle + 1, end]
                    start = middle + 1;
                }
                else
                {
                    // set the new searching interval to be [start, middle - 1]
                    end = middle - 1;
                }
            }
            // target not found
            return index;
        }
        //---------------------------------------------------------------

        /*
            Method: PrintArray()

        */
        static void PrintArray(string label, int[] arr)
        {
            Console.WriteLine(label);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);

                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
