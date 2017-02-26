/*
   <summary>    
   TITLE              Subset Sum                Chapter10Exercise9
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Print all subsets with specific sum
                      using iterative algorithm.

                      The algorithm is based on viewing all the combination
                      of indexes of the initial set as a binary number (`0`'s and `1`'s),
                      then in order to go through all the combinations
                      we simply increment through all the consecutive 
                      binary values from 0 to 2<sup>set cardinality</sup>
                      and sum the set elements that match the `1`'s
                      in the binary value, check the sum and print them
                      if sum matches the wanted value.

                      Or we iterate from 0 to 2<sup>set cardinality/2</sup>
                      of the binary and its complement.

                      Complexity O(N * 2^(N/2))
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
using System.Linq;

namespace Chapter10Exercise9
{
    class SubsetSumBinaryNumber
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 1, -1 };
            PrintSet(arr, "Initial Set:");

            int wantedSum = 4;
            Console.WriteLine("Wanted sum = {0}", wantedSum);

            FindSubsetSum(arr, wantedSum);
        }
        //-----------------------------------------------------------------------
        /*
            Method: FindSubsetSum(int[] arr)

        */
        private static void FindSubsetSum(int[] arr, int targetSum)
        {
            // convert to base 
            int toBase = 2;

            // length of binary number
            int length = arr.Length;

            // max value of binary number with "arr.Length" digits
            int iEnd = (int) Math.Pow(length, 2) / 2; 

            for (int number = 0; number < iEnd; number++)
            {
                // convert current number to binary array
                /*
                string binaryString = Convert.ToString(i, toBase).PadLeft(length, '0');
                bool[] binaryNumber = binaryString.Select(c => c == '1').ToArray();
                */
                bool[] binaryNumber = Enumerable.Range(1, length).Select(i => number / (1 << (length - i)) % 2 == 1).ToArray();

                // sum all elements with "true" indexes
                int currentSum = 0;
                int complementCurrentSum = 0;
                for (int j = 0; j < binaryNumber.Length; j++)
                {
                    if(binaryNumber[j] == true)
                    {
                        currentSum += arr[j];
                    }

                    if (binaryNumber[j] == false)
                    {
                        complementCurrentSum += arr[j];
                    }
                }

                // check for sum and print if equal
                if (currentSum == targetSum)
                {
                    PrintSubSet(arr, binaryNumber, true);
                }

                // check for complement sum
                if (complementCurrentSum == targetSum)
                {
                    PrintSubSet(arr, binaryNumber, false);
                }
            }
        }
        //-----------------------------------------------------------------------

        /*
            Method: PrintSubSet(int[] arr, bool[] subSet)

        */
        private static void PrintSubSet(int[] arr, bool[] subSet, bool print)
        {
            Console.Write("(");
            for (int i = 0; i < arr.Length; i++)
            {
                if (subSet[i] == print)
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
        //-----------------------------------------------------------------------

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
