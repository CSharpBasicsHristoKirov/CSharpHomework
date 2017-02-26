/*
   <summary>    
   TITLE              Find powerset          Chapter10Exercise5
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Print all powerset of a set of strings.
                      0, 1, 2,...n - 1 combinations without repetition.
               Input: {a, b , c}
              Output: () (a) (b) (c) (a, b) (a, c) (b, c)
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>12.10.2016</datecreated>
*/
using System;

namespace Chapter10Exercise5
{
    class StringPowerSet
    {
        static string[] set = { "test", "rock", "fun" };
        static int[] subSetIndexes;
        //-------------------------------------------------------------

        static void Main(string[] args)
        {
            PrintSet(set, "Initial set");

            FindPowerSet(set.Length);
        }
        //-------------------------------------------------------------

        /*
            Method: FindPowerSet(int n)

        */
        private static void FindPowerSet(int n)
        {
            // Super set - all sets with size: 0, 1, ..., n - 1
            for (int k = 0; k <= n - 1; k++)
            {
                subSetIndexes = new int[k];
                CombinationsNoRepetition(k, 0, n - 1);
            }
        }
        //-------------------------------------------------------------

        /*
            Method: CombinationsNoRepetition(int k, int iBegin, int iEnd);

        */
        private static void CombinationsNoRepetition(int k, int iBegin, int iEnd)
        {
            if (k == 0)
            {
                PrintSubSet();
                return;
            }

            for (int i = iBegin; i <= iEnd; i++)
            {
                subSetIndexes[k - 1] = i;
                ++iBegin;
                CombinationsNoRepetition(k - 1, iBegin, iEnd);
            }
        }
        //-------------------------------------------------------------

        /*
            Method: PrintSubSet()

        */
        private static void PrintSubSet()
        {
            Console.Write("(");
            for (int i = subSetIndexes.Length - 1; i >= 0; i--)
            {
                Console.Write(set[subSetIndexes[i]]);

                if (i > 0)
                {
                    Console.Write(" ,");
                }
            }
            Console.WriteLine(")");
        }
        //-------------------------------------------------------------

        /*
            Method: PrintSet(string[] arr)
        
        */
        private static void PrintSet(string[] arr, string label = "")
        {
            Console.WriteLine(label);

            Console.Write("(");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);

                if (i < arr.Length - 1)
                {
                    Console.Write(" ,");
                }
            }
            Console.WriteLine(")");
        }
    }
}
