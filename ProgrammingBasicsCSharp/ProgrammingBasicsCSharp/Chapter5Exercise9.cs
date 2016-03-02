/*
   <summary>    
   TITLE              Sum of subsets           Chapter5Exercise9.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Find a subset of elements that sum to 0.
                      Use only conditional statements.
                      Number of combinations of subsets out of a
                      set with size 5:

                      Size of subset:           Combinations:
                      1                         5
                      2                         10
                      3                         10
                      4                         5
                      5                         1

                                                Total:
                                                31
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>01.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter5Exercise9
    {

        static void Main()
        {
            const int size = 10;
            int[] set = new int[size] { -2, 2, -4, 5, -3 ,1, -1, -2, 2, 4};
            bool areThereAnySubsets = false;

            // 5 loops each checking for different size of subset
            Console.Write("Given the set: {");
            foreach (var item in set)
            {
                Console.Write(item + ", ");
            }
            Console.Write("}");

            Console.WriteLine("\nSubsets of one elements with sum equal to 0:");
            int length = size;
            for (int i = 0; i < length; i++)
            {
                if (set[i] == 0)
                {
                    Console.Write(set[i] + ", ");
                    areThereAnySubsets = true;
                }
            }

            Console.WriteLine("\nSubsets of two elements with sum equal to 0:");
            for (int i = 0; i <= length - 2 ; i++)
            {
                for (int j = i + 1; j <= length - 1; j++)
                {
                    if (set[i] + set[j] == 0 && set[i] != 0 && set[j] != 0)
                    {
                        Console.Write(set[i] + ", " + set[j] + "\n");
                        areThereAnySubsets = true;
                    }
                }
            }

            Console.WriteLine("\nSubsets of three elements with sum equal to 0:");
            for (int i = 0; i <= length - 3; i++)
            {
                for (int j = i + 1; j <= length - 2; j++)
                {
                    for (int k = j + 1; k <= length - 1; k++)
                    {
                        if (set[i] + set[j]  + set[k] == 0 && (set[i] != 0 && set[j] != 0 && set[k] != 0))
                        {
                            Console.Write(set[i] + ", " + set[j] + ", " + set[k] + "\n");
                            areThereAnySubsets = true;
                        }
                    }
                }
            }

            Console.WriteLine("\nSubsets of four elements with sum equal to 0:");
            for (int l = 0; l <= length - 4; l++)
            {
                for (int i = l + 1; i <= length - 3; i++)
                {
                    for (int j = i + 1; j <= length - 2; j++)
                    {
                        for (int k = j + 1; k <= length - 1; k++)
                        {
                            if (set[l] + set[i] + set[j] + set[k] == 0 && (set[i] != 0 && set[j] != 0 && set[k] != 0))
                            {
                                Console.Write(set[l] + ", " + set[i] + ", " + set[j] + ", " + set[k] + "\n");
                                areThereAnySubsets = true;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("\nSubset of five elements with sum equal to 0:");
            int sum = 0;
            for (int i = 0; i < length - 4; i++)
            {
                sum += set[i];
            }

            if (sum == 0)
            {
                areThereAnySubsets = true;
                foreach (var item in set)
                {
                    Console.Write(item + ", ");
                   
                }
            }

            if (!areThereAnySubsets)
            {
                Console.WriteLine("There are no subsets with sum of 0.");
            }
        }
    }
}
