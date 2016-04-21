/*
  <summary>    
  TITLE              Game Of Bits                      Program.cs
  Basic Level       -     Programming Basics        -    Homework 
  COMMENT
          Objective:  
              Input: -
             Output: -
  </summary>
  <author>Chris B. Kirov</author>
  <datecreated>20.04.2016</datecreated>
*/
using System;

namespace Game_Of_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            string binaryValue = Convert.ToString(number, 2);
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Game Over!")
                {
                    int setBitsCounter = 0;
                    for (int i = 0; i < binaryValue.Length; i++)
                    {
                        if (binaryValue[i] == '1')
                        {
                            setBitsCounter++;
                        }
                    }
                    int lastNumber = Convert.ToInt32(binaryValue, 2);
                    Console.WriteLine("{0} -> {1}", lastNumber, setBitsCounter);
                    break;
                }
                else if (command == "Odd")
                {
                    string oddBinary = string.Empty;
                    int index = 1;
                    for (int i = binaryValue.Length - 1; i >= 0 ; i--)
                    {
                        if (index % 2 != 0)
                        {
                            oddBinary = string.Concat(oddBinary, binaryValue[i]);
                        }
                        ++index;
                    }
                    char[] arr = oddBinary.ToCharArray();
                    Array.Reverse(arr);
                    binaryValue = new string(arr);
                }
                else if (command == "Even")
                {
                    string evenBinary = string.Empty;
                    int index = 1;
                    for (int j = binaryValue.Length - 1; j >= 0; j--)
                    {
                        if (index % 2 == 0)
                        {
                            evenBinary = string.Concat(evenBinary, binaryValue[j]);
                        }
                        ++index;
                    }
                    char[] arr = evenBinary.ToCharArray();
                    Array.Reverse(arr);
                    binaryValue = new string(arr);
                }
            }
        }
    }
}
