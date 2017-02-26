/*
   <summary>    
   TITLE              Subset Sum                 Chapter10Exercise8
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Print all subsets with specific sum.
               Input:  -
                       
              Output: 
                    Initial Set.
                    {2 ,3 ,1 ,-1}
                    Wanted sum = 4
                    (1 ,3)
                    (-1 ,3 ,2)
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>12.10.2016</datecreated>
*/
using System;

namespace Chapter10Exercise8
{
    class SubsetSum
    {
        static void Main(string[] args)
        {
            set = new int[] { 2, 3, 1, -1};
            PrintSet(set, "Initial Set.");

            sum = 4;
            Console.WriteLine("Wanted sum = {0}", sum);

            FindSubsetSum();
        }
        //-------------------------------------------------------------

        static int[] set;
        static int[] subSetIndexes;
        static int sum;
        static int numberOfSubsetSums;
        
        //------------------------------------------------------------

        /*
            Method: FindSubsetSum()
        */
        private static void FindSubsetSum()
        {
            numberOfSubsetSums = 0;
            int numberOfElements = set.Length;
            FindPowerSet(numberOfElements);
        }
        //-------------------------------------------------------------

        /*
            Method: FindPowerSet(int n, int k)

        */
        private static void FindPowerSet(int n)
        {
            // Super set - all sets with size: 0, 1, ..., n
            for (int k = 0; k <= n; k++)
            {
                subSetIndexes = new int[k];
                CombinationsNoRepetition(k, 0, n - 1);
            }

            if (numberOfSubsetSums == 0)
            {
                Console.WriteLine("No subsets with wanted sum exist.");
            }
        }
        //-------------------------------------------------------------

        /*
            Method: CombinationsNoRepetition(int k, int iBegin, int iEnd);

        */
        private static void CombinationsNoRepetition(int k, int iBegin, int iEnd)
        {
            if (k == 0)
            {
                if (CheckSubSetSum() == true)
                {
                    PrintSubSet();
                }
                return;
            }

            for (int i = iBegin; i <= iEnd; i++)
            {
                subSetIndexes[k - 1] = i;
                ++iBegin;
                CombinationsNoRepetition(k - 1, iBegin, iEnd);
            }
        }
        //-------------------------------------------------------------

        /*
            Method: CheckSubSetSum()
        
        */
        private static bool CheckSubSetSum()
        {
            int currentSubsetSum = 0;

            for (int i = 0; i < subSetIndexes.Length; i++)
            {
                currentSubsetSum += set[subSetIndexes[i]];
            }

            if (currentSubsetSum == sum)
            {
                ++numberOfSubsetSums;
                return true;
            }
            else
            {
                return false;
            }
        }
        //-------------------------------------------------------------

        /*
            Method: PrintSet()
        
        */
        private static void PrintSubSet()
        {
            Console.Write("(");
            for (int i = 0; i < subSetIndexes.Length; i++)
            {
                Console.Write(set[subSetIndexes[i]]);

                if (i < subSetIndexes.Length - 1)
                {
                    Console.Write(" ,");
                }
            }
            Console.WriteLine(")");
        }
        //-------------------------------------------------------------

        /*
            Method: PrintSet(string[] arr)
        
        */
        private static void PrintSet(int[] arr, string label = "")
        {
            Console.WriteLine(label);

            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);

                if (i < arr.Length - 1)
                {
                    Console.Write(" ,");
                }
            }
            Console.WriteLine("}");
        }
    }
}
