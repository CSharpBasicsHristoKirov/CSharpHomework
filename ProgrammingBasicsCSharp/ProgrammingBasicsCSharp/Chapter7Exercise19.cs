/*
   <summary>     
   TITLE              Prime numbers           Chapter7Exercise19.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Find the prime numbers within [1, 10^7]. 
             
                      It uses "The Sieve of Eratosthenes".
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>17.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise19
    {
        /*
	        Function: find_primes(boolArray);

            It returns all the prime numbers till the
            number: size_of_array, in the form of the
            indexes of the array with value: true.

            It implements the Sieve of Eratosthenes,
            consisted of:

	        a loop through the first "sqrt(size_of_array)"
	        numbers starting from the first prime(2).

	        a loop through all the indexes < size_of_array,
            marking the ones satisfying the relation i^2 + n*i
	        as false, i.e.composite numbers, where i - known prime
            number starting from 2.
        */
        static void findPrimes(bool[] sieve)
        {
            // by definition 0 and 1 are not prime numbers
            sieve[0] = false;
            sieve[1] = false;

            // all numbers <= max are potential candidates for primes
            for (uint i = 2; i < sieve.Length; ++i)
            {
                sieve[i] = true;
            }

            // loop through the first prime numbers < sqrt(max)  
            uint first_prime = 2;
            for (uint i = first_prime; i <= Math.Sqrt(sieve.Length); ++i)
            {
                // find multiples of primes till < max
                if (sieve[i] == true)
                {
                    // mark as composite: i^2 + n * i 
                    for (uint j = i * i; j < sieve.Length; j += i)
                    {
                        sieve[j] = false;
                    }
                }
            }
        }

        //----------------------------------------------------------------
        /*
            Function: print_primes(boolArray)

            It prints all the prime numbers, 
            i.e. the indexes with value: true.
        */
        static void printPrimes(bool[] sieve, int perLine)
        {
            // all the indexes of the array marked as true are primes
            for (uint i = 0; i < sieve.Length; ++i)
            {
                if (sieve[i] == true)
                {
                    Console.Write("{0}, ", i);
                }

                if (i % perLine == 0 && i !=0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        //==================================================================

        static void Main()
        {
            uint max = 1000000;
            bool[] sieve= new bool[max];

            findPrimes(sieve);

            int numbersPerLine = 50;
            printPrimes(sieve, numbersPerLine);
        }
    }
}
