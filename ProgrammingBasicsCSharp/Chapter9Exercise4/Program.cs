/*
   <summary>    
   TITLE              Frequency of n in array     Chapter9Exercise4
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read an integer n.
                      Find the frequency of n in an array.
                      Write a function that tests the 
                      validity of the result.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>01.04.2016</datecreated>
*/
using System;

namespace Chapter9Exercise4
{
    public class Program
    {
        /*
           Method: FrequencyOfN(int n, param int[] arr);

           It returns how many occurences of n
           there are within the array arr.
       */
        public static int FrequencyOfN(int TargetElement, params int[] Array)
        {
            int Count = 0;

            int Length = Array.Length;
            for (int i = 0; i < Length; i++)
            {
                if (TargetElement == Array[i])
                {
                    ++Count;
                }
            }

            return Count;
        }
        //==========================================================

        static void Main() 
        {
            int TargetElement = 5;
            Console.WriteLine("Number {0}, Occurence: {1}.",
                              TargetElement, FrequencyOfN(TargetElement), 1, 2, 3, 4, 5, 5);
        }
    }
}

