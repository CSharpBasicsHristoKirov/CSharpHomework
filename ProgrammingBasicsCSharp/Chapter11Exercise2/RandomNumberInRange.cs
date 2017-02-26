/*
   <summary>    
   TITLE              Random numbers in range    Chapter11Exercise2
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Generate 10 random number in the range [100, 200]. 
               Input: -
              Output: -
                  
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>15.10.2016</datecreated>
*/
using System;

namespace Chapter11Exercise2
{
    class RandomNumberInRange
    {
        static void Main(string[] args)
        {
            int numberOfRandoms = 100;
            int low = 100;
            int high = 200;
            foreach (var item in GenerateNRandom(numberOfRandoms, low, high))
            {
                Console.Write(" {0}", item);
            }
        }
        //-----------------------------------------------------------

        /*
            Data member: random
        */
        private static Random random = new Random();
        //-----------------------------------------------------------

        /*
            Method: RandomInRange(int low, int high)

        */
        private static int RandomInRange(int low, int high)
        {
            return random.Next(high - low) + low; 
        }
        //-----------------------------------------------------------

        /*
            Method: GenerateNRandom(int n)

        */
        private static int[] GenerateNRandom(int n, int low, int high)
        {
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = RandomInRange(low, high);
            }

            return numbers;
        }
    }
}
