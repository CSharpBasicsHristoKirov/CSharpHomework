/*
   <summary>    
   TITLE              Random Expression         Chapter11Exercise11
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Implement a program that generates an expression
                      with similar meaning, but with different 
                      words and names.
               Input: -
              Output: -
                  
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>16.10.2016</datecreated>
*/
using System;

namespace Chapter11Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            GenerateRandomPhrase();
        }
        //-----------------------------------------------------------------------------
        static Random random = new Random();

        //-----------------------------------------------------------------------------

        static string[] AdulationPhrase = { "Продуктът е отличен.", "Това е страхотен продукт.",
                                     "Постоянно ползвам този продукт.",
                                     "Това е най-добрият продукт от тази категория." };
        static string[] AdulationEvent = { " Вече се чувствам добре.", " Успях да се променя.",
                                    " Той направи чудо.",
                                    " Не мога да повярвам, но вече се чувствам страхотно.",
                                    " Опитайте и вие. Аз съм много доволна." };
        static string[] FirstName = { " - Диана", " - Петя", " - Стела", " - Елена", " - Катя" };
        static string[] LastName = { " Иванова", " Петрова", " Кирова" };
        static string[] City = { ", София", ", Пловдив", ", Варна", ", Русе", ", Бургас" };
        //-----------------------------------------------------------------------------

        /*
            Method: GenerateRandomPhrase();

        */
        private static void GenerateRandomPhrase()
        {
            string Phrase = AdulationPhrase[RandomInRange(0, AdulationPhrase.Length - 1)];
            Phrase += AdulationEvent[RandomInRange(0, AdulationEvent.Length - 1)];
            Phrase += FirstName[RandomInRange(0, FirstName.Length - 1)];
            Phrase += LastName[RandomInRange(0, LastName.Length - 1)];
            Phrase += City[RandomInRange(0, City.Length - 1)];

            Console.WriteLine(Phrase);
        }
        //-----------------------------------------------------------------------------

        /*
           Method: RandomInRange(int low, int high)

        */
        private static int RandomInRange(int low, int high)
        {
            return random.Next(high - low) + low;
        }
    }
}
