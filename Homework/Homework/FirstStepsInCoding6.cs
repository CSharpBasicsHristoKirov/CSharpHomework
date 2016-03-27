/*
  <summary>    
  TITLE              Triangle of 55 stars  FirstStepsInCoding6.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective: Print a right-angle triangle containing
                     55 asterisks `*`.
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>27.03.2016</datecreated>
*/
using System;

namespace Homework
{
    class FirstStepsInCoding6
    {
        static void Main()
        {
            int starsCounter = 0;
            
            int length = 2;
            for (int i = 1; i < length; i++)
            {
                // print till number of stars is 55 
                if (starsCounter >= 55)
                {
                    break;
                }

                string line = new string('*', i);
                Console.WriteLine(line);

                // accumlate number of stars
                starsCounter += i;

                // increase line length
                ++length;
            }
        }
    }
}
