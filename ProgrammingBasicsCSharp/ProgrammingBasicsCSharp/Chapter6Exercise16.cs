/*
   <summary>     
   TITLE              N random numbers within [1,N] Chapter6Exercise16.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a program that generates N random numbers
                      within the interval [1,N]. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>07.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise16
    {
        static void Main()
        {
            // read input
            Console.WriteLine("Print randomly the numbers from 1 to:");
            int n = int.Parse(Console.ReadLine());
            int[] randomNumbers = new int[n];

            // instantiate a random generator
            Random rand = new Random();

            // populate an array with random numbers within [1, n]
            for (int i = 0; i < n; i++)
            {
                randomNumbers[i] = rand.Next(1, n + 1);
            }

            // print result
            Console.WriteLine("Randomly generated number within [1,{0}]", n);
            foreach (var element in randomNumbers)
            {
                Console.WriteLine(element);
            }
        }
    }
}
