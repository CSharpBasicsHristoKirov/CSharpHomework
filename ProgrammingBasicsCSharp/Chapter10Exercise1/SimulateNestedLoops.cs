/*
   <summary>    
   TITLE              Simulate Nested Loops      Chapter10Exercise1  
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read number of loops n.
                      Simulate n nested loops of n iterations each
                      and print their values.
                      n^n - permutations / lines should be printed.
               Input: 2
              Output: 11 12 21 22
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>12.10.2016</datecreated>
*/
using System;

namespace Chapter10Exercise1
{
    class SimulateNestedLoops
    {
        /* 
           keeps current permutation, 
           i.e. values of local variable for each outer loop 
        */
        static int[] permutation;
        //------------------------------------------------------------------

        static void Main(string[] args)
        {
            Console.WriteLine("Type n:");
            int n = int.Parse(Console.ReadLine());

            permutation = new int[n];

            NestedLoops(n, n);
        }
        //------------------------------------------------------------------

        /*
           Method: NestedLoops(int NumberOfLoops)

           A direct recurrence based method simulating
           nested loops. Where NumberOfLoops additionally
           indicates recurrence depth.
        */
        public static void NestedLoops(int NumberOfLoops, int Iterations)
        {
            // print all "local variables" in the innermost "for" loop and start over / exit
            if (NumberOfLoops == 0)
            {
                PrintPermutation();
                return;
            }

            for (int i = 1; i <= Iterations; i++)
            {
                // store local-variable-value of current "for" loop
                permutation[NumberOfLoops - 1] = i;
                // proceed to inner "for" loop
                NestedLoops(NumberOfLoops - 1, Iterations);
            }
        }
        //------------------------------------------------------------------

        /*
            Method: PrintPermutation()

            Prints current permutation.
        */
        public static void PrintPermutation()
        {
            for (int i = permutation.Length - 1; i >= 0; --i)
            {
                Console.Write(permutation[i]);
            }
            Console.WriteLine();
        }
    }
}
