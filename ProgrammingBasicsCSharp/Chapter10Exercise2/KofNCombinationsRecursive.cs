/*
   <summary>    
   TITLE              k of n Combinations      Chapter10Exercise2 
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
    class KofNCombinationsRecursive
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
        */
        private static void FindCombinations(int n, int k)
        {
            combination = new int[k];
            RecCombinations(k, 1, n);
        }
        //--------------------------------------------------------------------------

        /*
            Method: RecCombinations(n, iBeg, iEnd)

        */
        private static void RecCombinations(int k, int iBeg, int iEnd)
        {
            if (k == 0)
            {
                PrintCombination();
                return;
            }

            for (int i = iBeg; i <= iEnd; i++)
            {
                combination[k - 1] = i;
                RecCombinations(k - 1, iBeg, iEnd);
                ++iBeg;
            }
        }

        //--------------------------------------------------------------------------

        /*
            Method: PrintCombination()

        */
        private static void PrintCombination()
        {
            Console.Write("(");
            for (int i = combination.Length - 1; i >= 0; --i)
            {
                Console.Write(combination[i]);

                if (i > 0)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(")");
        }
    }
}
