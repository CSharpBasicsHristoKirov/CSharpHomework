/*
	TITLE           Wine Glass    Exam14042014WineGlass.cs
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
    class Exam14042014WineGlass
    {
        /*
            Method: multipleOfChar(character, times, emptyElement)

            It returns a string consisted of multiples (specified by: times) 
            of the chracter passed as first argument. Third parameter specifies
            the string returned when times = 0. 
        */
        static string multipleOfChar(string c, int times, string emptyElement)
        {
            if (times == 0)
            {
                // white space or nothing
                return emptyElement;
            }

            string multiple = string.Empty;
            for (int i = 0; i < times; i++)
            {
                multiple += c;
            }
            return multiple;
        }

        static void Main()
        {
            int height = int.Parse(Console.ReadLine());

            int numberOfAsterisks = height - 2;
            int numberOfDots = 0;
            for (int i = 0; i < height; i++)
            {
                if (i < height / 2)
                {
                    Console.Write(multipleOfChar(".", numberOfDots, ""));

                    Console.Write("\\");

                    Console.Write(multipleOfChar("*", numberOfAsterisks, ""));
                    // symmetrical 
                    Console.Write("/");

                    Console.Write(multipleOfChar(".", numberOfDots, ""));

                    // newline
                    Console.WriteLine();

                    numberOfAsterisks -= 2;
                    numberOfDots++;
                }
                else if ((height < 12 && i < height -1) || (height >= 12 && i < height -2))
                {
                    Console.Write(multipleOfChar(".", numberOfDots - 1, ""));
                    Console.Write("||");
                    Console.Write(multipleOfChar(".", numberOfDots - 1, ""));

                    // newline
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(multipleOfChar("-", height, ""));
                    Console.WriteLine();
                }
            }
        }
    }
}
