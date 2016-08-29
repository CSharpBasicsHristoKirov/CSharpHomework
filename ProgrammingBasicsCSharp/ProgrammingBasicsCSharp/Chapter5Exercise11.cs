/*
   <summary>    
   TITLE              Find a number name      Chapter5Exercise11.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: It returns the name of a number withing the 
                      interval [0,999].
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>05.03.2016</datecreated>
*/
using System;
using System.Linq;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter5Exercise11
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(numberName(i));

                if (i % 100 == 0) Console.ReadKey();
            }
            
        }
        //---------------------------------------------------------------------------------------

        /*
            Method: numberName(int number);

            It returns the name of the integer
            parameter; within [0, 999].
        */
        static string numberName(int number)
        {
            if (number == 0)
            {
                return "нула";
            }

            const int size = 10;
            string[] units = new string[size - 1] {"едно", "две", "три", "четири", "пет",
                                                   "шест", "седем", "осем", "девет" };
            string[] teens = new string[size] {"десет", "единадесет", "дванадесет", "тринадесет",
                                               "четиринадесет", "петнадесет", "шестнадесет",
                                               "седемнадесет", "осемнадесет", "деветнадесет" };
            string[] tens = new string[size - 2] {"двадесет", "тридесет", "четиридесет", "петдесет",
                                                  "шестдесет", "седемдесет", "осемдесет", "деветдесет"};
            string[] hundrets = new string[size - 1] {"сто", "двеста", "триста", "четиристотин", "петстотин",
                                                      "шестстотин", "седемстотин", "осемстотин", "деветстотин"};
            // will hold the number name
            string name = string.Empty;

            // extract each digit of the input number
            char[] digitsAsChar = number.ToString().ToCharArray();
            int[] digitsAsInt = digitsAsChar.Select(a => a - '0').ToArray();

            switch (digitsAsInt.Length)
            {
                case 0: name += "empty"; break;
                case 1: name += units[digitsAsInt[0] - 1]; break;
                case 2:
                    {
                        if (digitsAsInt[0] < 2)
                        {
                            name += teens[digitsAsInt[1]];
                        }
                        else if (digitsAsInt[1] == 0 && digitsAsInt[0] > 1)
                        {
                            name += tens[digitsAsInt[0] - 2];
                        }
                        else
                        {
                            name += tens[digitsAsInt[0] - 2] + " и " + units[digitsAsInt[1] - 1];
                        }

                        break;
                    }
                case 3:
                    {
                        name += hundrets[digitsAsInt[0] - 1];

                        if (digitsAsInt[1] == 0 && digitsAsInt[2] > 0)
                        {
                            name += " и " + units[digitsAsInt[2] - 1];
                        }
                        else if (digitsAsInt[1] == 0 && digitsAsInt[2] == 0)
                        {

                        }
                        else if (digitsAsInt[1] < 2 && digitsAsInt[1] > 0)
                        {
                            name += " и " + teens[digitsAsInt[2]];
                        }
                        else if (digitsAsInt[2] == 0 && digitsAsInt[1] > 1)
                        {
                            name += " и " + tens[digitsAsInt[1] - 2];
                        }
                        else
                        {
                            name += " " + tens[digitsAsInt[1] - 2] + " и " + units[digitsAsInt[2] - 1];
                        }

                        break;
                    }
                default: name += "not supported format!"; break;
            }

            return name;
        }

    }
}
