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
        static void Main() 
        {
            int target = 5;
            int[] arr = { 1, 2, 3, 4, 5, 5 };

            Console.WriteLine("Number {0}, Occurence: {1}.",
                              target, FrequencyOfN(target, arr));
        }
        //------------------------------------------------------------------------------------

        /*
           Method: FrequencyOfN();

           It returns how many occurences of n
           there are within the array.
       */
        public static int FrequencyOfN(int target, params int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (target == arr[i])
                {
                    ++count;
                }
            }
            return count;
        }
    }
}

