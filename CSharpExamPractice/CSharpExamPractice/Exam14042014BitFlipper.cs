/*
	TITLE           Bit Flipper     Exam14042014BitFlipper.cs
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
    class Exam14042014BitFlipper
    {
        static void Main()
        {
            ulong inputNumber = ulong.Parse(Console.ReadLine());

            // 00000111
            ulong mask = 7;

            int length = sizeof(ulong) * 8 - 2;
            for (int shiftBits = length; shiftBits-- > 0 ;)
            {
                ulong LSBs = inputNumber >> shiftBits;

                // it complements three consecitive identical bits
                ulong areBitsSet = (LSBs & mask);
                if (areBitsSet == 7 || areBitsSet == 0)
                {
                    // reset/set bits
                    inputNumber = inputNumber ^ (mask << shiftBits);
                    shiftBits -= 2;
                }
            }
            // print modified number
            Console.WriteLine(inputNumber);
        }
    }
}
