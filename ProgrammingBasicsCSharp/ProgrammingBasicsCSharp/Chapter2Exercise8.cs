///<summary> 
///TITLE              String & Object      Chapter2Exercise8.cs 
///    COMMENT
///        Objective: Define two strings using
///                   "Hello" and "World".
///                   Initialize an object type variable
///                   with the concatenation
///                   between the two strings.
///            Input: -
///           Output: Hello World
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>22.02.2016</datecreated>
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter2Exercise8
    {
        static void Main()
        {
            string var1 = "Hello";
            string var2 = "World";
            // concatenate and use as initialization value
            object var3 = var1 + " " + var2;
            // explicit type casting from type object to type string
            string var4 = (string) var3;

            Console.WriteLine(var4);
        }
    }
}
