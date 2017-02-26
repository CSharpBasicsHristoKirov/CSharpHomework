/*
   <summary>    
   TITLE              Subset Sum                Chapter10Exercise9
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Print all subsets with specific sum
                      using iterative algorithm.

                      Use dynamic programming: https://en.wikipedia.org/wiki/Subset_sum_problem
               Input:  -
                       
              Output: 
                    Initial Set.
                    {2 ,3 ,1 ,-1}
                    Wanted sum = 4
                    (1 ,3)
                    (-1 ,3 ,2)
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>14.10.2016</datecreated>
*/
using System;

namespace Chapter10Exercise9
{
    class SubsetSumIterative
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 1, -1 };
            PrintSet(arr, "Initial Set:");

            int wantedSum = 4;
            Console.WriteLine("Wanted sum = {0}", wantedSum);

            FindSubsetSum(arr, wantedSum);
        }
        //------------------------------------------------------------------------------------------------------------------

        /*
            Method: FindSubsetSum(int[] arr)

        */
        private static void FindSubsetSum(int[] arr, int targetSum)
        {
            bool[] subSet = new bool[arr.Length];
            int currentSum = 0;
            int index = 0;
            SubsetSumDynamicProgramming(arr, currentSum, index, targetSum, subSet);
        }
        //------------------------------------------------------------------------------------------------------------------

        /*
            Method: SubsetSumDynamicProgramming(int[] arr, int currentSum, int index, sum, int[] subSet)

        */
        private static void SubsetSumDynamicProgramming(int[] arr, int currentSum, int index, int targetSum, bool[] subSet)
        {
            if (currentSum == targetSum)
            {
                PrintSubSet(arr, subSet);

            }
            else if (index == arr.Length)
            {
                return;
            }
            else
            {
                // include element with current index
                subSet[index] = true;
                currentSum += arr[index];
                SubsetSumDynamicProgramming(arr, currentSum, index + 1, targetSum, subSet);

                // exclude element with current index
                currentSum -= arr[index];
                subSet[index] = false;
                SubsetSumDynamicProgramming(arr, currentSum, index + 1, targetSum, subSet);
            }
        }
        //------------------------------------------------------------------------------------------------------------------

        /*
            Method: PrintSubSet(int[] arr, bool[] subSet)

        */
        private static void PrintSubSet(int[] arr, bool[] subSet)
        {
            Console.Write("(");
            for (int i = 0; i < arr.Length; i++)
            {
                if (subSet[i] == true)
                {
                    Console.Write(arr[i]);

                    if (i < arr.Length - 1)
                    {
                        Console.Write(" ,");
                    }
                }
            }
            Console.WriteLine(")");
        }
        //------------------------------------------------------------------------------------------------------------------

        /*
            Method: PrintSet(int[] arr, string label = "")

        */
        private static void PrintSet(int[] arr, string label = "")
        {
            Console.WriteLine(label);

            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);

                if (i < arr.Length - 1)
                {
                    Console.Write(" ,");
                }
            }
            Console.WriteLine("}");
        }
    }
}

