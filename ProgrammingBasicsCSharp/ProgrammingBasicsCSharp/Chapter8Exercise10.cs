/*
   <summary>    
   TITLE             Binary to decimal; Horner  Chapter8Exercise10.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Convert from binary to decimal using the
                      Horner method.
                      https://en.wikipedia.org/wiki/Horner%27s_method
                      all coefficients are 2.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>26.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter8Exercise10
    {
        /*
            Method: int dec = binaryToDecimalHornerIteratively(binaryString);

            It returns an integer representing the decimal value
            of the input parameter. Implements the Horner method
            iteratively.
        */
        static int binaryToDecimalHornerIteratively(string binaryString)
        {
            // copy in reverse order; convert to int
            int[] binaryArray = new int[binaryString.Length];
            for (int i = 0, j = binaryArray.Length - 1; i < binaryArray.Length; i++, j--)
            {
                binaryArray[j] = binaryString[i] - '0';
            }

            // initialize with the MSB
            int sum = binaryArray[binaryArray.Length - 1];

            for (int i = binaryArray.Length - 2; i >= 0; i--)
            {
                sum = 2 * sum + binaryArray[i];
            }

            return sum;
        }

        //------------------------------------------------------------------------
        /*
            Method: int dec = binaryToDecimalHornerRecursively(binaryString);

            It returns an integer representing the decimal value
            of the input parameter. Implements the Horner method
            recursively.
        */
        static int binaryToDecimalHornerRecursively(string binaryString)
        {
            // copy in reverse order; convert to int
            int[] binaryArray = new int[binaryString.Length];
            for (int i = 0, j = binaryArray.Length - 1; i < binaryArray.Length; i++, j--)
            {
                binaryArray[j] = binaryString[i] - '0';
            }

            return horner(binaryArray, 0);
        }

        //------------------------------------------------------------------------
        /*
           Method: horner(binaryArray, currentIndex);

           It implements the Horner method.
       */
        static int horner(int[] binaryArray, int currentIndex)
        {
            if (currentIndex == binaryArray.Length - 1)
            {
                return binaryArray[binaryArray.Length - 1];
            }
            else
            {
                return 2 * horner(binaryArray, currentIndex + 1) + binaryArray[currentIndex];
            }
        }


        //===========================================================
        static void Main()
        {
            Console.WriteLine("Type a number in binary representation:");
            string binary = Console.ReadLine();

            Console.WriteLine("{0}(2) -> {1}(10)", binary, binaryToDecimalHornerIteratively(binary));
            Console.WriteLine("{0}(2) -> {1}(10)", binary, binaryToDecimalHornerRecursively(binary));
        }
    }
}
