/*
    TITLE          Student Cables   Exam14042014StudentCables.cpp
    COMMENT
        Objective: https://judge.softuni.bg/Contests/9/CSharp-Basics-Exam-14-April-2014-Evening
            Input: -
           Output: -
           Author: Chris B. Kirov
             Date: 02.03.2016
*/
using System;
using System.Text;

namespace CSharpExamPractice
{
    class Exam14042014StudentCables
    {
        static void Main()
        {
            // read input
            int numberOfCables= int.Parse(Console.ReadLine());

            int[] cableLength = new int[numberOfCables];
            string[] measure = new string[numberOfCables];

            int totalLength = 0;
            int numberofConnections = -1;

            for (int i = 0; i < numberOfCables; i++)
            {
                cableLength[i] = int.Parse(Console.ReadLine());
                measure[i] = Console.ReadLine();

                // convert all to centimeters
                if (measure[i] == "meters")
                {
                    cableLength[i] *= 100;
                }

                // discard short cables
                if (cableLength[i] < 20)
                {
                    cableLength[i] = 0;
                }
                else
                {
                    ++numberofConnections;
                    totalLength += cableLength[i];
                }
            }

            int connectionLoss = 3;
            totalLength -= numberofConnections * connectionLoss;

            int readyCableLenght = 504;
            int studentCables = totalLength / readyCableLenght;
            int remainder = totalLength - (studentCables * readyCableLenght);

            Console.WriteLine(studentCables);
            Console.WriteLine(remainder);
        }
    }
}
