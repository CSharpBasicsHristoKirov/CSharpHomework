/*
  <summary>    
  TITLE              Encrypted Matrix                  Program.cs
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

namespace EncryptedMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            char diagonal = char.Parse(Console.ReadLine());

            // convert to number
            string messageAsNumber = string.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                int ASCIIvalue = message[i];
                int lastDigit = ASCIIvalue % 10;
                messageAsNumber += lastDigit;
            }

            // encrypt
            string encryptedMessage = string.Empty;
            for (int i = 0; i < messageAsNumber.Length; i++)
            {
                int number = messageAsNumber[i] - '0';

                if (number % 2 == 0 || number == 0)
                {
                    number *= number;
                }
                else
                {
                    int smaller = 0;
                    if (i - 1 >= 0)
                    {
                        smaller = messageAsNumber[i - 1] - '0';
                    }

                    int larger = 0;
                    if (i + 1 < messageAsNumber.Length)
                    {
                        larger = messageAsNumber[i + 1] - '0';
                    }

                    number += smaller + larger;
                }

                encryptedMessage += number;
            }

            if (diagonal == '\\')
            {
                for (int i = 0; i < encryptedMessage.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(0 + " ");
                    }

                    Console.Write(encryptedMessage[i] + " ");

                    for (int k = encryptedMessage.Length - 2 - i; k >= 0; k--)
                    {
                        Console.Write(0 + " ");
                    }
                    Console.WriteLine();
                }
            }
            else if (diagonal == '/')
            {
                for (int i = 0; i < encryptedMessage.Length; i++)
                {
                    for (int j = encryptedMessage.Length - 2 - i; j >= 0; j--)
                    {
                        Console.Write(0 + " ");
                    }

                    Console.Write(encryptedMessage[encryptedMessage.Length - 1 - i] + " ");

                    for (int k = 0; k < i; k++)
                    {
                        Console.Write(0 + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}