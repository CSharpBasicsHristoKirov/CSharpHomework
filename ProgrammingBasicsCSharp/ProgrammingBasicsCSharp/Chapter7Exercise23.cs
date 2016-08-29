/*
   <summary>     
   TITLE              Permutations of n numbers Chapter7Exercise23.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read n. Print the all possible permutations 
                      (without repetition) within [1, n].  

                      number of permutations (without repetitions) = n!
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>18.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise23
    {
        static void Main()
        {
            // read input
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            // find permutations
            PrintPermutations(n);

            Console.WriteLine();
        }
        //-----------------------------------------------------------------------

        /*
           Method: PrintPermutations(n);

           Wrapper of the recursive function
           printing all the permutations of the
           elements stored in arr.
       */
        static void PrintPermutations(int n)
        {
            // define and initialize an array
            int[] numbers = new int[n];
            InitializeArray(numbers, n);

            Console.Write("->");
            int indexOfLast = numbers.Length - 1;
            int indexOfFirst = 0;

            Permute(numbers, indexOfFirst, indexOfLast);
        }
        //-----------------------------------------------------------------------

        /*
            Method: Permute(arr);

            It prints all permutations of the elements 
            in arr by recursively swapping each of the 
            elements with the rest.
        */
        static void Permute(int[] arr, int currentActivationRecord, int lastActivationRecord)
        {
            // print permutation
            if (currentActivationRecord == lastActivationRecord)
            {
                PrintArray(", ", arr);
            }
            else
            {
                for (int i = currentActivationRecord; i <= lastActivationRecord; i++)
                {
                    Swap(ref arr[currentActivationRecord], ref arr[i]);

                    // recursive call
                    Permute(arr, currentActivationRecord + 1, lastActivationRecord);

                    Swap(ref arr[currentActivationRecord], ref arr[i]);
                }
            }
        }
        //-----------------------------------------------------------------------

        /*
            Method: Swap(a, b);

        */
        static void Swap(ref int a, ref int b)
        {
            if (a != b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
        }
        //-----------------------------------------------------------------------

        /*
            Method: PrintArray(label, arr);

            Print the array elements.
        */
        static void PrintArray(string label, int[] arr)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);

                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("}");
            Console.Write(label);
        }
        //-----------------------------------------------------------------------

        /*
            Method: InitializeArray();

        */
        static void InitializeArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
        }
    }
}
