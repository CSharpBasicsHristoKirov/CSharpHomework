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
    class KofNVariationsRecursive
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
            RecVariation(k, 1, n);
        }

        //--------------------------------------------------------------------------

        /*
            Method: RecVariation()

        */
        private static void RecVariation(int k, int iBeg, int iEnd)
        {
            if (k == 0)
            {
                PrintVariation();
                return;
            }

            for (int i = iBeg; i <= iEnd; i++)
            {
                variation[k - 1] = i;
                RecVariation(k - 1, iBeg, iEnd);
            }
        }

        //--------------------------------------------------------------------------

        /*
            Method: PrintVariation()
        */
        private static void PrintVariation()
        {
            Console.Write("(");
            for (int i = variation.Length - 1; i >= 0; --i)
            {
                Console.Write(variation[i]);

                if (i > 0)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(")");
        }
    }
}
