/*
   <summary>    
   TITLE             Greerings by name Method  Chapter9Exercise1.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Implement a method that prints a greeting
                      with a name passed as parameter. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.03.2016</datecreated>
*/
using System; 

namespace ProgrammingBasicsCSharp
{
    public class Chapter9Exercise1
    {
        static void Main()
        {
            // member function is not static, thus it can be only accessed via object instantiation
            Chapter9Exercise1 objectInstantiation = new Chapter9Exercise1();

            objectInstantiation.GreetinsByName();
        }
        //------------------------------------------------------------------------------------------------

        /*
            Method: GreetinsByName(string name)

        */
        public void GreetinsByName()
        {
            Console.WriteLine("Type your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
        }

    }
}
