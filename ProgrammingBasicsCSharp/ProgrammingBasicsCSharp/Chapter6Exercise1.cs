﻿/*
   <summary>    
   TITLE              Print N numbers          Chapter6Exercise1.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read a number n. 
                      Print all the numbers from 1 to n.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>05.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise1
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
