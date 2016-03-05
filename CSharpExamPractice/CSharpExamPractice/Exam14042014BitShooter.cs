/*
	TITLE           Bit Shooter         Exam14042014BitShooter.cs
	COMMENT
		Objective : https://judge.softuni.bg/Contests/9/CSharp-Basics-Exam-14-April-2014-Evening
			Input : -
		   Output : -
		   Author : Chris B.Kirov
			 Date : 02.03.2016
*/
using System;
using System.Text;
namespace CSharpExamPractice
{
    class Exam14042014BitShooter
    {
        /*
            Method: ulong num = setLSBits(size);

            It returns an unsinged integer with
            "size" set least significant bits.
        */
        static ulong setLSBits(int size)
        {
            ulong LSB = 0;
            for (int i = 0; i < size; i++)
            {
                LSB += (ulong)Math.Pow(2, i);
            }
            return LSB;
        }

        /*
            Method: ulong bulet = makeBulet(center, size);

            It returns an unsinged integer with
            "size" set bits around bit position "center".
        */
        static ulong makeBulet(int center, int size)
        {
            // underflow
            if (center < size / 2)
            {
                return setLSBits(size / 2 + 1);
            }

            // adjust the bits to be around the center
            center -= size / 2;
            return setLSBits(size) << center;
        }

        /*
            Method: ulong remainingBits = shoot(number, bulet);

            It returns the result of bitwise AND between the number
            and the complement of the bulet.
        */
        static ulong shoot(ulong number, ulong bulet) 
        {
            return number & (~bulet);
        }

        //=======================================================================

        static void Main()
        {
            // read input
            ulong number = ulong.Parse(Console.ReadLine());

            int numberOfShots = 3;
            ulong[] bulets = new ulong[numberOfShots];
            for (int i = 0; i < numberOfShots; i++)
            {
                string input = Console.ReadLine();
                string[] differentiate = input.Split(' ');

                int center = int.Parse(differentiate[0]);
                int size = int.Parse(differentiate[1]);

                bulets[i] = makeBulet(center, size);
            }

            // accumulate all bulets
            ulong burst = 0;
            for (int i = 0; i < numberOfShots; i++)
            {
                burst |= bulets[i];
            }

            // shoot 
            ulong remainingBits = shoot(number, burst);

            // count the number of set bits of the first and last 32 bits
            ulong LSB32 = 0;
            ulong MSB32 = 0;
            int lengthOfULong = 64;
            for (int i = 0; i < lengthOfULong; i++)
            {
                if (i < 32)
                {
                    // check if LSB is 1
                    LSB32 += remainingBits & 1;
                }
                else
                {
                    // check if LSB is 1
                    MSB32 += remainingBits & 1;
                }
                // shift to the right; (truncate LSB) 
                remainingBits >>= 1;
            }

            // print result
            Console.WriteLine("left: {0}", MSB32);
            Console.WriteLine("right: {0}", LSB32);
        }
    }
}
