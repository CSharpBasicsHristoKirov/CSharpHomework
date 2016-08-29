/*
   <summary>    
   TITLE              Simulate Nested Loops      Chapter10Exercise13 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read number of loops n.
                      Simulate n nested loops of n iterations each and print
                      their values.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>05.04.2016</datecreated>
*/
using System;

namespace Chapter10Exercise1
{
    class SimulateNestedLoops
    {
        /*
            Method: NestedLoops(int NumberOfLoops)
        
             
        */
        public static void NestedLoops(int NumberOfLoops, int Iterations)
        {
            if (NumberOfLoops == 0)
            {
                return;
            }

            for (int i = 1; i <= Iterations; i++)
            {
                Console.Write(i);
                NestedLoops(NumberOfLoops - 1, Iterations);
                Console.WriteLine();
            }
        }
        //------------------------------------------------------------------

        /*
            Method: PrintLoops
        */


        //==================================================================

        static void Main(string[] args)
        {
            //  NestedLoops(2, 2);

            DateTime startTime = DateTime.Now;

            long sum = 0;
            for (int i = 0; i < 30000000; i++)
            {
                sum = sum + i / 100000;
            }

            Console.WriteLine(DateTime.Now - startTime);
        }
    }
}
