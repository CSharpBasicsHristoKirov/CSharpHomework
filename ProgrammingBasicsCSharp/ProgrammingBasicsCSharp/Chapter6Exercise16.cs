/*
   <summary>     
   TITLE              N random numbers within [1,N] Chapter6Exercise16.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a program that generates N random numbers
                      within the interval [1,N]. 
                      
                      ! It could be done by random swapping such that 
                      there are no duplicates. !
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>07.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise16
    {
        static void Main()
        {
            // read input
            Console.WriteLine("Print randomly the numbers from 1 to:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            InitializeArray(arr);
            RandomizeArrayElements(arr);
            PrintArray(arr);
        }
        //-----------------------------------------------------------------------------------------------------

        /*
            Method: InitializeArray(int[] arr)

            It initializes the elements of the 
            array with the numbers from 1 to n.
        */
        static void InitializeArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
        }
        //-----------------------------------------------------------------------------------------------------

        /*
            Method: RandomizeArrayElements(int[] arr)

            It swaps random pairs of elements in the array.
        */
        static void RandomizeArrayElements(int[] arr)
        {
            Random random = new Random();
            // i = number of swaps
            for (int i = 0; i < arr.Length / 2; i++)
            {
                // random lower half index swapped with random upper half
                int smallIndex = random.Next(0, arr.Length / 2);
                int largeIndex = random.Next((arr.Length / 2) + 1, arr.Length - 1);

                int temp = arr[smallIndex];
                arr[smallIndex] = arr[largeIndex];
                arr[largeIndex] = temp;
            }
        }
        //-----------------------------------------------------------------------------------------------------

        /*
            Method: PrintArray(int[] arr);

        */
        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
    }
}
