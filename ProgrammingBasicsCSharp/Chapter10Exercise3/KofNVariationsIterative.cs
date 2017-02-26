/*
   <summary>    
   TITLE              k of n Variations      Chapter10Exercise3 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Print all variations with repetition of k 
                      elements out of a set of n elements.
               Input: n = 3
                      к = 2
              Output: (1 1), (1 2), (1 3), (2 1), (2 2), (2 3), (3 1), (3 2), (3 3)
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>12.10.2016</datecreated>
*/
using System;

namespace Chapter10Exercise3
{
    class KofNVariationsIterative
    {
        static int[] variation;
        //--------------------------------------------------------------------------

        static void Main(string[] args)
        {
            Console.WriteLine("Type n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Type k:");
            int k = int.Parse(Console.ReadLine());

            FindVariations(n, k);
        }
        //--------------------------------------------------------------------------

        /*
            Method: FindVariations();

        */
        private static void FindVariations(int n, int k)
        {
            variation = new int[k];
            int initialValue = 1;
            InitializeArray(variation, initialValue);
            int valueAfterOverflow = 1;

            while (true)
            {
                PrintVariation();

                int index = k - 1;
                ++variation[index];

                while (variation[index] > n)
                {
                    variation[index] = valueAfterOverflow;
                    --index;

                    if (index < 0)
                    {
                        return;
                    }
                    ++variation[index];
                }
            }
        }
        //--------------------------------------------------------------------------

        /*
            Method: PrintVariation()

        */
        private static void PrintVariation()
        {
            Console.Write("(");
            for (int i = 0; i < variation.Length; ++i)
            {
                Console.Write(variation[i]);

                if (i < variation.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(")");
        }
        //--------------------------------------------------------------------------

        /*
            Method: InitializeArray(int[] arr, int initialValue)
            
        */
        static void InitializeArray(int[] arr, int initialValue)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = initialValue;
            }
        }
    }
}
