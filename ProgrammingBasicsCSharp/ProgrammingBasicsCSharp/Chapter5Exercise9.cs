/*
   <summary>    
   TITLE              Sum of subsets           Chapter5Exercise9.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Find a subset of elements that sum to 0.

               Input: {3, -2, 1, 1};
              Output: {-2, 1, 1};
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>01.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter5Exercise9
    {
        static void Main()
        {
            int[] set1 = { 3, -2, 1, 1};
            int[] set2 = { 3, 1, -7, 35, 22 };

            ZeroSumSubsets(set2);
        }
        //-----------------------------------------------

        /*
            Method: ZeroSumSubsets();

            It finds and prints all the subsets whose
            elements sum to 0.
        */
        static private void ZeroSumSubsets(int[] set)
        {
            // lower bound of subset
            for (int min = 0; min < set.Length - 1; min++)
            {
                // upped bound of subset
                for (int max = min + 1; max <= set.Length; max++)
                {
                    // accumulate current subset
                    int index = 0;
                    int[] subset = new int[max - min];

                    for (int i = min; i < max; i++)
                    {
                        subset[index++] = set[i];
                    }

                    PrintZeroSumSubset(subset);
                }
            }
        }

        //-----------------------------------------------

        /*
            Method: PrintZeroSumSubset();

            It prints all the subsets whose
            elements sum to 0.
        */
        static private void PrintZeroSumSubset(int[] subset)
        {
            int sum = 0;
            for (int j = 0; j < subset.Length; j++)
            {
                sum += subset[j];
            }

            // if sum == 0 print subset
            if (sum == 0)
            {
                Console.Write("{");
                for (int k = 0; k < subset.Length; k++)
                {
                    Console.Write(subset[k]);

                    if (k < subset.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("}");
            }
        }
    }
}
