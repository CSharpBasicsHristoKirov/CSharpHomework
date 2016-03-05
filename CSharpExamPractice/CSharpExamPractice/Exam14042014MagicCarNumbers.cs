/*
	TITLE           Magic Car Numbers     Exam14042014MagicCarNumbers.cs
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
    class Exam14042014MagicCarNumbers
    {
        static bool isMagic(int a, int b, int c, int d)
        {
            bool allSame = (a == b && b == c && c == d);
            bool lastThree = (b == c && c == d);
            bool firstThree = (a == b && b == c);
            bool pairs = (a == b && c == d);
            bool periodic = (a == c && b == d);
            bool symmetric = (a == d && b == c);

            return allSame || lastThree || firstThree || pairs || periodic || symmetric;
        }

        static void Main()
        {
            int[] letterValues = { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };

            int magicWeight = int.Parse(Console.ReadLine());

            // all numbers start with CA, i.e. 30 + 10
            int prefixWeight = 40;
            int numberOfCarsWithSameMagicNumber = 0;

            // generate all combinations of: abcd XY
            int length = 10;
            for (int a = 0; a < length; a++)
            {
                for (int b = 0; b < length; b++)
                {
                    for (int c = 0; c < length; c++)
                    {
                        for (int d = 0; d < length; d++)
                        {
                            for (int x = 0; x < length; x++)
                            {
                                for (int y = 0; y < length; y++)
                                {
                                    if (isMagic(a, b, c, d) &&
                                        (prefixWeight +
                                         a + b + c + d +
                                         letterValues[x] +
                                         letterValues[y] == magicWeight))
                                    {
                                        ++numberOfCarsWithSameMagicNumber;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            // print result
            Console.WriteLine(numberOfCarsWithSameMagicNumber);
        }
    }
}
