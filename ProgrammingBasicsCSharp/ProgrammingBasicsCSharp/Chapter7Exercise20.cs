/*
   <summary>     
   TITLE              Sum in array            Chapter7Exercise20.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Define an int array of n values.
                      Define an int "sum". Check if there is a subarray
                      with elements that sum up to "sum".
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>18.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise20
    {
        /*
            Method: isSubarrayWithSum(arr, sum);

            It returns a bool value that indicates
            whether there is a subarray within arr
            with elements that sum up to the value
            passed by the second parameter.
        */
        static bool isThereSubarrayWithSum(int[] arr, int sum)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int currentSum = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    currentSum += arr[j];

                    if (currentSum == sum)
                    {
                        printArrayWithin(arr, i, j);

                        return true;
                    }
                }
            }
            return false;
        }
        //--------------------------------------------------------------------
        /*
            Method: printArrayWithin(arr, iStart, iEnd);

            It prins the elements of the array with index 
            from iStart to iEnd. 
        */
        static void printArrayWithin(int[] arr, int iStart, int iEnd)
        {
            Console.Write("\n{");
            for (int k = iStart; k <= iEnd; k++)
            {
                Console.Write(arr[k]);

                if (k < iEnd)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("}\n");
        }

        //====================================================================

        static void Main()
        {
            int[] numbers = { 1, 4, 20, 3, 10, 5 };
            int wantedSum = 33;  

            Console.Write("There is ");
            if (!isThereSubarrayWithSum(numbers, wantedSum))
            {
                Console.Write("no ");
            }
            Console.Write("subarray with elements with sum {0}.\n", wantedSum);
        }
    }
}
