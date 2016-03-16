/*
   <summary>     
   TITLE              Find array Mode         Chapter7Exercise10.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Find the most frequently occuring array element.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>14.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise10
    {
        /*
            Method: findMode(arr);

            It prints the mode value and its frequency.
            O (n^2).
        */
        static void findMode(int[] arr)
        {
            int mode = 0;
            int frequency = 1;
            // check each element 
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int currentFrequency = 1;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        currentFrequency++;
                    }
                }
                // is current element the mode
                if (currentFrequency > frequency)
                {
                    frequency = currentFrequency;
                    mode = arr[i];
                }
                // if mode's frequency is larger than the rest of the elements quit  
                if (frequency > (length - 1) - i)
                {
                    break;
                }
            }
            // print result
            Console.WriteLine("{0} and occurs {1}.", mode, frequency);
        }

        //==================================================================
        static void Main()
        {
            int[] numbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            findMode(numbers);
        }
    }
}
