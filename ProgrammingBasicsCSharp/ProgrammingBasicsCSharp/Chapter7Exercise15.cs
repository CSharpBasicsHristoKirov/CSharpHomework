/*
   <summary>     
   TITLE              Index of letter         Chapter7Exercise15.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Type a word and print the indexes of each
                      of the letters that compose it.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>16.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise15
    {
        static void Main()
        {
            InitializeArray(alphabet);

            Console.WriteLine("Type a word in lower case:");
            
            string word = Console.ReadLine();

            PrintLetterIndexes(word);
        }
        //--------------------------------------------------------------------------------------------

        // data members
        const int length = 26;
        static char[] alphabet = new char[length];

        //--------------------------------------------------------------------------------------------

        // member methods
        /*
            Method: InitializeArray(char[] arr)

        */
        static void InitializeArray(char[] arr)
        {
           
            for (int i = 0; i < arr.Length; i++)
            {
                char letter = (char)('a' + i);
                arr[i] = letter;
            }
        }
        //--------------------------------------------------------------------------------------------

        /*
            Method: FindIndex(char letter)

            It returns the index of the letter in the 
            array.
            Assumes array stores English alphabet.
        */
        static int FindIndex(char letter)
        {
            int length = alphabet.Length;
            for (int i = 0; i < length; i++)
            {
                if (alphabet[i] == letter)
                {
                    return i;
                }
            }
            return -1;
        }
        //--------------------------------------------------------------------------------------------

        /*
            Method: PrintLetterIndexes(string word)

        */
        static void PrintLetterIndexes(string word)
        {
            Console.WriteLine("The indexes of the letters in the word: {0} are:", word);
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(" " + FindIndex(word[i]));
            }
            Console.WriteLine();
        }
    }
}
