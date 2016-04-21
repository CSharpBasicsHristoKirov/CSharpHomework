/*
   <summary>    
   TITLE              Find Max & Sort             Chapter9Exercise9  
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Implement a method the returns the subarray 
                      element with max value.
                      Use the method to sort in ascending / descending order.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>02.04.2016</datecreated>
*/
using System;

namespace Chapter9Exercise9
{
    public class Program
    {
        /*
            Method: FindMax(int[] Array, int StartIndex, int EndIndex);

            Return the index of the subarray [StartIndex, EndIndex]
            element with Max value.
        */
        public static int FindMax(int[] Array, int StartIndex, int EndIndex)
        {
            if (StartIndex < 0 || EndIndex >= Array.Length || StartIndex > EndIndex)
            {
                throw new ArgumentOutOfRangeException();
            }

            int MaxIndex = -1;
            int MaxValue = int.MinValue;

            for (int i = StartIndex; i <= EndIndex; i++)
            {
                if (Array[i] > MaxValue)
                {
                    MaxValue = Array[i];
                    MaxIndex = i;
                }
            }

            return MaxIndex;
        }
        //----------------------------------------------------------

        /*
            Method: Swap(ref int a, ref int b);


        */
        public static void Swap(ref int a, ref int b)
        {
            if (a != b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
        }

        //----------------------------------------------------------

        /*
            Method: SelectionSortAscending(int[] Array);

            It sorts the array in ascending order
            by iteratively finding the element with
            Max value and swapping its value with the
            last element.
        */
        public static void SelectionSortAscending(int[] Array)
        {
            int length = Array.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                int MaxIndex = FindMax(Array, 0, i);

                if (MaxIndex != i)
                {
                    Swap(ref Array[MaxIndex], ref Array[i]);
                }
            }
        }

        //----------------------------------------------------------

        /*
            Method: SelectionSortDescending(int[] Array);

            It sorts the array in descending order
            by iteratively finding the element with
            Max value and swapping its value with the
            first element.
        */
        public static void SelectionSortDescending(int[] Array)
        {
            int length = Array.Length;
            for (int i = 0; i < length; i++)
            {
                int MaxIndex = FindMax(Array, i, length - 1);

                if (MaxIndex != i)
                {
                    Swap(ref Array[MaxIndex], ref Array[i]);
                }
            }
        }

        //----------------------------------------------------------

        /*
           Method: PrintArray(int[] Array);

       */
        public static void PrintArray(string label, int[] Array)
        {
            Console.WriteLine(label);
            Console.Write("{");

            int length = Array.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write(Array[i]);

                if (i < length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.Write("}\n");
        }

        //==========================================================

        static void Main(string[] args)
        {
            int[] Numbers = {9, 8, 7, 6, 5, 4, 3 ,2 ,1 };

            PrintArray("Initial array:", Numbers);

            SelectionSortAscending(Numbers);

            PrintArray("In ascending order:", Numbers);

            SelectionSortDescending(Numbers);

            PrintArray("In Descending order", Numbers);
        }
    }
}
