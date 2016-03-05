/*
	TITLE           Biggest Triple    Exam14042014BiggestTriple.cs
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
    class Exam14042014BiggestTriple
    {
        static void Main()
        {
            string input = Console.ReadLine();

            // separate by whitespace 
            string[] tokens = input.Split();

            // tokens to numbers
            int[] numbers = Array.ConvertAll(tokens, int.Parse);

            // numbers less than three in total
            if (numbers.Length <= 3)
            {
                foreach (var item in numbers)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                return;
            }
            
            // calculate max sum of three elements
            int maxSum = -3001;
            int indexOfFirst = 0;
            int indexOfSecond = 0;
            int indexOfThird = 0;

            int length = numbers.Length;
            for (int i = 0; i < length; i += 3)
            {
                int first = (i < length) ? numbers[i] : 0;
                int second = (i + 1 < length) ? numbers[i + 1] : 0;
                int third = (i + 2 < length) ? numbers[i + 2] : 0;

                int currentSum = first + second + third;

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    indexOfFirst = (i < length) ? i : -1;
                    indexOfSecond = (i + 1 < length) ? i + 1 : -1;
                    indexOfThird = (i + 2 < length) ? i + 2 : -1;
                }
            }

            // print result
            Console.Write(numbers[indexOfFirst]);
            if (indexOfSecond != -1)
            {
                Console.Write(" " + numbers[indexOfSecond]);

                if (indexOfThird != -1)
                {
                    Console.Write(" " + numbers[indexOfThird]);
                }
            }
            Console.WriteLine();
        }
    }
}
