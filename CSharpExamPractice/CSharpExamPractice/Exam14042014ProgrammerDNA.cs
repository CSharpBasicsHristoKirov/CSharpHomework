/*
	TITLE           Programmer DNA     Exam14042014ProgrammerDNA.cs
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
    class Exam14042014ProgrammerDNA
    {
		static void Main()
		{
			int length = int.Parse(Console.ReadLine());
            char currentLeter = char.Parse(Console.ReadLine());
            char dot = '.';

            int width = 7;
            int numberOfLetters = 1;
            bool isRising = (numberOfLetters < 7);

            for (int i = 0; i < length; i++)
            {
                int difference = (width - numberOfLetters) / 2;
                for (int j = 0; j < difference; j++)
                {
                    Console.Write(dot);
                }

                for (int k = 0; k < numberOfLetters; ++k)
                {
                    Console.Write(currentLeter);
                    // increment with step 1 within [A, G]
                    currentLeter = (currentLeter < 'G') ? (++currentLeter) : 'A';
                }
				
                for (int j = 0; j < difference; j++)
                {
                    Console.Write(dot);
                }

                Console.Write("\n");

                if ((i > 0 && i < length - 1) && numberOfLetters == 1 && isRising)
                {
                    for (int j = 0; j < difference; j++)
                    {
                        Console.Write(dot);
                    }

                    Console.Write(currentLeter);
                    // increment with step 1 within [A, G]
                    currentLeter = (currentLeter < 'G') ? (++currentLeter) : 'A';
                    ++i;

                    for (int j = 0; j < difference; j++)
                    {
                        Console.Write(dot);
                    }

                    Console.Write("\n");
                }

                // incerement / decrement with step 2 within [1,7]
                numberOfLetters += (isRising) ? +2 : -2;

                if (numberOfLetters >= 7 || numberOfLetters <= 1)
                {
                    isRising = !isRising;
                }
            }
		}
    }
}
