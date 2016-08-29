/*
   <summary>     
   TITLE              K variations out of n   Chapter7Exercise24.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read n and k. Print the all possible variations
                      (without repetition) of k elements within [1, n].  

                      number of variations = n! / (n - k)!
                      or all permutations of n with group of k elements.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>18.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise24
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            PrintVariations(n, k);
        }
        //-----------------------------------------------------------------------

        /*
           Method: PrintVariations(n, k);

           Wrapper for the recursive function.
           It prints all the k variations
           out of n elements.
       */
        static void PrintVariations(int n, int k)
        {
            // define and initialize an array of elements to choose from
            int[] elements = new int[n];
            InitializeArray(elements, n);

            // number of selected elements
            Variations(elements, k, new int[k]);
        }
        //-----------------------------------------------------------------------

        /*
            Method:  Variations(arr, length, ithVariation);

            Recursive function that accumulates all the (k == length) variations
            in array ithVariation and when filled up it prints it.

            Base case: check arguments and if
                       k == currentNumberOfElementsInVariation: => print them

            Recursive step: - run through the remaining elements.
                            - add the element at position [currentRecursionDepth]
                              to the array of variations
                              at [k - currentNumberOfElementsInVariations]. 
                            - update currentNumberOfElementsInVariations.
                            - calls itself with updated arguments.
        */
        static void Variations(int[] arr, int length, int[] ithVariation)
        {
            // if k elements added to the variation: print it
            if (length == 0)
            {
                PrintArray(", ", ithVariation);
                return;
            }

            // go through all the elements  
            for (int i = 0; i < arr.Length; i++)
            {
                ithVariation[ithVariation.Length - length] = arr[i];

                Variations(arr, length - 1, ithVariation);
            }
        }
        //-----------------------------------------------------------------------

        /*
            Method: PrintArray(label, arr);

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
