/*
   <summary>    
   TITLE              Permutations                 Chapter10Exercise7
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Print all permutations of set of n elements.

               Input: n = 
                      3
              Output: (1, 2, 3), (1, 3, 2), (2, 1, 3), (2, 3, 1), (3, 1, 2), (3, 2, 1) 
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>12.10.2016</datecreated>
*/
using System;

namespace Chapter10Exercise7
{
    class Permutations
    {
        static void Main(string[] args)
        {
            int setSize = 3;
            FindPermutations(setSize);
        }
        //-----------------------------------------------------------------------------

        /*
            Method: FindPermutations(n)

        */
        private static void FindPermutations(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
            int iBegin = 0;
            Permute(arr, iBegin);
        }
        //-----------------------------------------------------------------------------

        /*
            Method: Permute(arr)


        */
        private static void Permute(int[] arr, int iBegin)
        {
            if (iBegin == arr.Length - 1)
            {
                PrintArray(arr);
                return;
            }

            for (int i = iBegin; i < arr.Length; i++)
            {
                swap(ref arr[i], ref arr[iBegin]);

                Permute(arr, iBegin + 1);

                swap(ref arr[i], ref arr[iBegin]);
            }
        }
        //-----------------------------------------------------------------------------
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
        //-----------------------------------------------------------------------------

        /*
            Method: swap(ref int a, ref int b)

        */
        private static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
