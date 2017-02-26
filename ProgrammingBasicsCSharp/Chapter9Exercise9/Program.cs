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
        static void Main(string[] args)
        {
            int[] numbers = {9, 8, 7, 6, 5, 4, 3 ,2 ,1 };

            PrintArray("Initial array:", numbers);

            SelectionSortAscending(numbers);

            PrintArray("In ascending order:", numbers);

            SelectionSortDescending(numbers);

            PrintArray("In Descending order", numbers);
        }
        //----------------------------------------------------------

        /*
            Method: FindMax();

            Return the index of the subarray [StartIndex, EndIndex]
            element with Max value.
        */
        public static int FindMax(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex < 0 || endIndex >= arr.Length || startIndex > endIndex)
            {
                throw new Exception("FindMax: Invalid Parameter!");
            }

            int maxIndex = -1;
            int maxValue = int.MinValue;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
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
        public static void SelectionSortAscending(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int maxIndex = FindMax(arr, 0, i);

                if (maxIndex != i)
                {
                    Swap(ref arr[maxIndex], ref arr[i]);
                }
            }
        }
        //----------------------------------------------------------

        /*
            Method: SelectionSortDescending();

            It sorts the array in descending order
            by iteratively finding the element with
            Max value and swapping its value with the
            first element.
        */
        public static void SelectionSortDescending(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                int maxIndex = FindMax(arr, i, length - 1);

                if (maxIndex != i)
                {
                    Swap(ref arr[maxIndex], ref arr[i]);
                }
            }
        }
        //----------------------------------------------------------

        /*
           Method: PrintArray(int[] Array);

        */
        public static void PrintArray(string label, int[] arr)
        {
            Console.WriteLine(label);
            Console.Write("{");

            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i]);

                if (i < length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
        }
    }
}
