/*
   <summary>    
   TITLE              k of n Combinations        Chapter10Exercise2 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Print all combinations with repetition of k
                      elements out of a set of n elements.
               Input: n = 3
                      к = 2
              Output: (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>12.10.2016</datecreated>
*/
using System;

namespace Chapter10Exercise2
{
    class KofNCombinationsIterative
    {
        static int[] combination;
        //--------------------------------------------------------------------------

        static void Main(string[] args)
        {
            Console.WriteLine("Type n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Type k:");
            int k = int.Parse(Console.ReadLine());

            FindCombinations(n, k);
        }
        //--------------------------------------------------------------------------

        /*
            Method: FindCombinations(int n, int k)

            It prints the combinations of k elements
            in a set of n elements.

            It increments the values of an array of size k
            from 1 to n, starting from the last element.
        */
        private static void FindCombinations(int n, int k)
        {
            combination = new int[k];
            int initialValue = 1;
            InitializeArray(combination, initialValue);
            int valueAfterOverflow = 1;

            while (true)
            {
                // print current combination
                PrintCombination();

                // increase value at current index
                int index = k - 1;
                ++combination[index];

                // go to smaller index when we iterate through all values at current index 
                while (combination[index] > n)
                {
                    ++valueAfterOverflow;
                    combination[index] = valueAfterOverflow;
                    --index;

                    // if current index is < 0 exit
                    if (index < 0)
                    {
                        return;
                    }
                    ++combination[index];
                }
            }
        }
        //--------------------------------------------------------------------------

        /*
            Method: PrintCombination()

        */
        private static void PrintCombination()
        {
            Console.Write("(");
            for (int i = 0; i < combination.Length; ++i)
            {
                Console.Write(combination[i]);

                if (i < combination.Length - 1)
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
