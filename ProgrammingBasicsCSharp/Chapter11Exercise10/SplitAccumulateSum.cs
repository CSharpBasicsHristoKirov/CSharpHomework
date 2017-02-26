/*
   <summary>    
   TITLE              Accumulate sum            Chapter11Exercise10
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Given a string of numbers separated by comma
                      calculate their total sum.
               Input: -
              Output: -
                  
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>16.10.2016</datecreated>
*/
using System;

namespace Chapter11Exercise10
{
    class SplitAccumulateSum
    {
        static void Main(string[] args)
        {
            string input = "1,2,3,4,5,6,7,8,9,10";
            int[] numbers = StringToIntArray(input);
            
            Console.WriteLine("Sum is = {0}.", AccumulateSum(numbers));
        }
        //-------------------------------------------------------

        /*
            Method: StringToIntArray(string input)

        */
        private static int[] StringToIntArray(string input)
        {
            string[] separateElements = input.Split(',');

            int[] numbers = new int[separateElements.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(separateElements[i]);
            }
            return numbers;
        }
        //-------------------------------------------------------

        /*
            Method: AccumulateSum(int[] number)

        */
        private static int AccumulateSum(int[] number)
        {
            int sum = 0;
            foreach (var item in number)
            {
                sum += item;
            }
            return sum;
        }
    }
}
