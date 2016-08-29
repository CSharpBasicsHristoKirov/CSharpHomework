/*
   <summary>     
   TITLE              Sequence with specific sum  Chapter7Exercise11.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Type a sum n; find a sequence that sums up to n,
                      within an existing array.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>14.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise11
    {
        static void Main()
        {
            Console.WriteLine("Find if there is a subarray that sums up to specific value.");
            int[] numbers = { 4, 3, 1, 4, 2, 5, 8 };

            Console.WriteLine("Type a sum:");
            int sum = int.Parse(Console.ReadLine());

            ElementsWithSum(numbers, sum);
        }
        //----------------------------------------------------------------

        /*
            Method: ElementsWithSum(arr, sum);

            It prints the sequence of elements that sum
            up to the value passed as second parameter.
        */
        static void ElementsWithSum(int[] arr, int sum)
        {
            bool exists = false;
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                int currentSum = arr[i];
                for (int j = i + 1; j < length; j++)
                {
                    currentSum += arr[j];
                    if (currentSum == sum)
                    {
                        // print sequence
                        Console.WriteLine("Sum = {0}", sum);
                        Console.Write("{");
                        for (int k = i; k <= j; k++)
                        {
                            Console.Write(arr[k]);

                            if (k < j)
                            {
                                Console.Write(", ");
                            }
                        }
                        Console.Write("}\n");
                        exists = !exists;
                    }
                }
            }

            if (!exists)
            {
                Console.WriteLine("No seqeunce with such sum exists!\n");
            }
        }
    }
}
