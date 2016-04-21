/*
  <summary>    
  TITLE              Array Matcher                   Program.cs
  Basic Level  -  Programming Basics - Exam_29_March_2015_Evening
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>21.04.2016</datecreated>
*/
using System;

namespace Array_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char delimeter = '\\';
            string[] tokens = input.Split(delimeter);

            string result = string.Empty;
            if (tokens[2] == "join")
            {
                for (int i = 0; i < tokens[0].Length; i++)
                {
                    for (int j = 0; j < tokens[1].Length; j++)
                    {
                        if (tokens[0][i] == tokens[1][j])
                        {
                            result += tokens[0][i];
                        }
                    }
                }
            }
            else if (tokens[2] == "right exclude")
            {
                bool unique = true;
                for (int i = 0; i < tokens[0].Length; i++)
                {
                    for (int j = 0; j < tokens[1].Length; j++)
                    {
                        if (tokens[0][i] == tokens[1][j])
                        {
                            unique = false;
                            break;
                        }
                    }

                    if (unique)
                    {
                        result += tokens[0][i];
                    }

                    unique = true;
                }
            }
            else if (tokens[2] == "left exclude")
            {
                bool unique = true;
                for (int i = 0; i < tokens[1].Length; i++)
                {
                    for (int j = 0; j < tokens[0].Length; j++)
                    {
                        if (tokens[0][j] == tokens[1][i])
                        {
                            unique = false;
                            break;
                        }
                    }

                    if (unique)
                    {
                        result += tokens[1][i];
                    }

                    unique = true;
                }
            }

            char[] array = result.ToCharArray();
            Array.Sort(array);

            foreach (var item in array)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
    }
}
