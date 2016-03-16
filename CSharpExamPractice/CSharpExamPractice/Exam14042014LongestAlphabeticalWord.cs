/*
	TITLE          Longest Alphabetical Word   Exam14042014LongestAlphabeticalWord.cs
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
    class Exam14042014LongestAlphabeticalWord
    {
        static string word = string.Empty;
        static int dimension;
        static string longestAlphabeticalWord = string.Empty;
        //====================================================================================

        static void Main()
        {
            // read input
            word = Console.ReadLine();
            dimension = int.Parse(Console.ReadLine());

            // check every element of the 2D character matrix
            for (int row = 0; row < dimension; row++)
            {
                for (int column = 0; column < dimension; column++)
                {
                    char currentCharacter = wordMatrix(row, column);
                    checkToTheLeft(currentCharacter, row, column);
                    checkToTheRight(currentCharacter, row, column);
                    checkToTheTop(currentCharacter, row, column);
                    checkToTheBottom(currentCharacter, row, column);
                }
            }

            // print resul
            Console.WriteLine(longestAlphabeticalWord);
        }

        //====================================================================================
        /*
           Method: wordMatrix(word, index, row, column);

           It simulates a 2D matrix populated with the
           sequence of characters of the word passed
           as first parameter.

           It returns the "matrix element" specified by the
           last two parameters.
       */
        static char wordMatrix(int row, int column)
        {
            return word[(dimension * row + column) % word.Length];
        }

        /*
            Method: isLongestWord(testString);

            It applyes the rules for longest
            alphabetical word on the parameter
            and if they are true the parameter
            becomes the new longest word.
        */
        static void isLongestWord(string testString)
        {
            // if there is no current maximum
            if (longestAlphabeticalWord.Length == 0)
            {
                longestAlphabeticalWord = testString;
                return;
            }

            //  if parameter longer or equal and lexicographically smaller
            if (testString.Length > longestAlphabeticalWord.Length ||
                (testString.Length == longestAlphabeticalWord.Length &&
                longestAlphabeticalWord.CompareTo(testString) > 0))
            {
                longestAlphabeticalWord = testString;
            }
        }

        /*
               Method: checkToTheLeft(string currentCharacter, int row, int column);

               It traverses the current row till the end (or till there are
               no more lexicographically larger than the currentCharacter characters)
               and appends the characters that are lexicographically larger to the
               currentCharacter.

               When finished it checks if the formed string is the new longest word.
         */
        static void checkToTheLeft(char currentCharacter, int row, int column)
        {
            string test = string.Empty;
            test += currentCharacter;

            // if element is in the first row, nothing to ckeck on the left
            int i = column - 1;
            if (i < 0)
            {
                return;
            }

            while (i >= 0)
            {
                char lastCharacter = wordMatrix(row, i + 1);

                if (wordMatrix(row, i) > lastCharacter)
                {
                    test += wordMatrix(row, i);
                }
                else
                {
                    break;
                }

                --i;
            }
            // check the maximum
            isLongestWord(test);
        }

        /*
               Method: checkToTheRight(string currentCharacter, int row, int column);

               It traverses the current row till the end (or till there are
               no more lexicographically larger than the currentCharacter characters)
               and appends the characters that are lexicographically larger to the
               currentCharacter.

               When finished it checks if the formed string is the new longest word.
         */
        static void checkToTheRight(char currentCharacter, int row, int column)
        {
            string test = string.Empty;
            test += currentCharacter;

            // if element is in the first row, nothing to ckeck on the right
            int i = column + 1;
            if (i > dimension)
            {
                return;
            }

            while (i < dimension)
            {
                char lastCharacter = wordMatrix(row, i - 1);

                if (wordMatrix(row, i) > lastCharacter)
                {
                    test += wordMatrix(row, i);
                }
                else
                {
                    break;
                }

                ++i;
            }
            // check the maximum
            isLongestWord(test);
        }

        /*
               Method: checkToTheTop(string currentCharacter, int row, int column);

               It traverses the current column till the top (or till there are
               no more lexicographically larger than the currentCharacter characters)
               and appends the characters that are lexicographically larger to the
               currentCharacter.

               When finished it checks if the formed string is the new longest word.
         */
        static void checkToTheTop(char currentCharacter, int row, int column)
        {
            string test = string.Empty;
            test += currentCharacter;

            // if element is in the first row, nothing to ckeck on the top
            int i = row - 1;
            if (i < 0)
            {
                return;
            }

            while (i >= 0)
            {
                char lastCharacter = wordMatrix(i + 1, column);

                if (wordMatrix(i, column) > lastCharacter)
                {
                    test += wordMatrix(i, column);
                }
                else
                {
                    break;
                }

                --i;
            }
            // check the maximum
            isLongestWord(test);
        }

        /*
              Method: checkToTheBottom(string currentCharacter, int row, int column);

              It traverses the current column till the top (or till there are
              no more lexicographically larger than the currentCharacter characters)
              and appends the characters that are lexicographically larger to the
              currentCharacter.

              When finished it checks if the formed string is the new longest word.
        */
        static void checkToTheBottom(char currentCharacter, int row, int column)
        {
            string test = string.Empty;
            test += currentCharacter;

            // if element is in the first row, nothing to ckeck on the top
            int i = row + 1;
            if (i > dimension)
            {
                return;
            }

            while (i < dimension)
            {
                char lastCharacter = wordMatrix(i - 1, column);

                if (wordMatrix(i, column) > lastCharacter)
                {
                    test += wordMatrix(i, column);
                }
                else
                {
                    break;
                }

                ++i;
            }
            // check the maximum
            isLongestWord(test);
        }
    }
}
