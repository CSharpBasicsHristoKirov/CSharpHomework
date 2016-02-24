/*
   <summary> 
   TITLE              Digit manipulation      Chapter3Exercise10.cs 
      COMMENT
           Objective: 1. Read four digit number in the format abcd.
                      2. Calculate sum of digits: a + b + c + d
                      3. Print reversed:          dcba
                      4. Print shifted & rotated: dabc
                      5. Print swapped middle:    acbd
               Input: Type an integer with even number of digits:
                      1234
              Output: Sum of digits of: 1234 is: 10
                      The reverse of: 1234 is: 4321
                      abcd: 1234 dabc: 4123
                      abcd: 1234 acbd: 1324
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>24.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise10
    {
        static void Main()
        {
            // 1. Read an integer in the format abcd
            Console.WriteLine("Type an integer with even number of digits: ");
            int inputVariable = Convert.ToInt32(Console.ReadLine());

            // 2. Calculate sum of digits: a + b + c + d
            int sumOfDigits = 0;
            int divisor = 10;
            int temporary = inputVariable;
            int digitNumber = (inputVariable.ToString()).Length;
            for (int i = 0; i < digitNumber; i++)
			{
                // get last digit               
                int remainder = temporary % divisor;

                // add last digit to sum
                sumOfDigits += remainder;

                // truncate least significand digit
                int truncated = temporary / divisor;

                // update with truncated value
                temporary = truncated;
	        }
            Console.WriteLine("Sum of digits of: " + inputVariable + " is: " + sumOfDigits);

            //  3. Print reversed: dcba
            string reversedNumber = null;
            int loopLocalVariable = inputVariable;
            for (int i = 0; i < digitNumber; i++)
            {
                // get last digit               
                int remainder = loopLocalVariable % divisor;

                // concatenate last digit to string
                reversedNumber += remainder.ToString();

                // truncate least significand digit
                int truncated = loopLocalVariable / divisor;

                // update with truncated value
                loopLocalVariable = truncated;
            }
            Console.WriteLine("The reverse of: " + inputVariable + " is: " + reversedNumber);

            // 4. Print shifted & rotated: dabc
            int lastDigit = inputVariable % divisor;

            string shiftedAndRotated = lastDigit.ToString();

            int firstThreeDigits = inputVariable / divisor;

            shiftedAndRotated += firstThreeDigits.ToString();
            Console.WriteLine("abcd: " + inputVariable + " dabc: " + shiftedAndRotated);

            // 5. Print swapped middle: acbd
            string stringInput = inputVariable.ToString();
            string swappedMiddle = String.Empty;
            int index = (digitNumber / 2) - 1; // elements start from 0
            for (int i = 0; i < digitNumber; i++)
            {
                // swap when the middle is reached
                if (i == index)
                {
                    // concatenate next element
                    swappedMiddle += stringInput[index + 1];
                    // concatenate current element
                    swappedMiddle += stringInput[index];
                    // skip next element
                    i++;
                }
                else
                {
                    swappedMiddle += stringInput[i];
                }
            }
            Console.WriteLine("abcd: " + inputVariable + " acbd: " + swappedMiddle);
        }
    }
}
