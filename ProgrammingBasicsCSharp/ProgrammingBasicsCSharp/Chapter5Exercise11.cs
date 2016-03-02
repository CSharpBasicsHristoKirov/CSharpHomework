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
   <datecreated>01.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter5Exercise11
    {
        const int size = 10;
        string[] units = new string[size] { "нула", "едно", "две", "три", "четири", "пет", "шест", "седем", "осем", "девет" };
        string[] tens = new string[1] { "десет" };
    }
}
