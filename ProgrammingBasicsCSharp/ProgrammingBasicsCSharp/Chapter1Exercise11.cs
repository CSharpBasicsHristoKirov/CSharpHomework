///TITLE              I/O              Chapter1Exercise11.cs 
///    COMMENT
///        Objective: Read age; print age after 10 years. 
///            Input: i
///           Output: i + 10
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>15.02.2016</datecreated>

using System;
using System.Text;
using System.Globalization;

namespace ProgrammingBasicsCSharp
{
    class Chapter1Exercise11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your age:");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("After 10 years you will be: {0}", age + 10);
        }
    }
}