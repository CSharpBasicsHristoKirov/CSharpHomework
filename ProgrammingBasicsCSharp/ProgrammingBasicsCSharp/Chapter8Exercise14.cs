/*
   <summary>    
   TITLE              Rounding error & Execution Time  Chapter8Exercise14.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Accumulate the first: 50 000 000 terms of a sum
                      with constant term: 0.000001, where the term is
                      stored in: float, double and decimal.
                      
                      Compare result value and execution time. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>26.03.2016</datecreated>
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProgrammingBasicsCSharp
{ 
    class Chapter8Exercise14
    {
        /*
            Method: sumFloat();
        */
        static void sumFloat()
        {
            float result = 0;

            int length = 50000000;
            for (int i = 0; i < length; i++)
            {
                result += 0.000001f;
            }
            float absError = Math.Abs(50 - result);
            Console.WriteLine("Float result: {0}\nAbsolute error: {1}", result, absError);
        }

        //---------------------------------------------------
        /*
            Method: sumDouble();
        */
        static void sumDouble()
        {
            double result = 0;

            int length = 50000000;
            for (int i = 0; i < length; i++)
            {
                result += 0.000001d;
            }
            double absError = Math.Abs(50 - result);
            Console.WriteLine("Double result: {0}\nAbsolute error: {1}", result, absError);
        }

        //---------------------------------------------------
        /*
            Method: sumDecimal();
        */
        static void sumDecimal()
        {
            decimal result = 0;

            int length = 50000000;
            for (int i = 0; i < length; i++)
            {
                result += 0.000001m;
            }
            decimal absError = Math.Abs(50 - result);
            Console.WriteLine("Decimal result: {0}\nAbsolute error: {1}", result, absError);
        }

        //===================================================

        static void Main()
        {
            // FLOAT
            Stopwatch sw1 = Stopwatch.StartNew();
            sumFloat();
            sw1.Stop();
            Console.WriteLine("Time taken: {0}ms\n", sw1.Elapsed.TotalMilliseconds);

            // DOUBLE
            Stopwatch sw2 = Stopwatch.StartNew();
            sumDouble();
            sw2.Stop();
            Console.WriteLine("Time taken: {0}ms\n", sw2.Elapsed.TotalMilliseconds);

            // DECIMAL
            Stopwatch sw3= Stopwatch.StartNew();
            sumDecimal();
            sw3.Stop();
            Console.WriteLine("Time taken: {0}ms\n", sw3.Elapsed.TotalMilliseconds);
        }
    }
}
