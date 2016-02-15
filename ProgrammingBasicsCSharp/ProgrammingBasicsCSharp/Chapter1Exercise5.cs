///<summary> 
///TITLE              Output Cyrillic    Chapter1Exercise5.cs 
///    COMMENT
///        Objective: Use WriteLine() class. 
///            Input: -
///           Output: Добър Ден!            
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>15.02.2016</datecreated>

using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter1Exercise5
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Добър Ден!");
        }
    }
}