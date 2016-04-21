using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using ProgrammingBasicsCSharp;
using System.IO;

namespace GreetingsByNameTest
{
    [TestClass]
    public class GreetingsByNameTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // redirect standard output stream to StringWriter
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // instantiate an object and call the tested member function

            // Chapter9Exercise1 testObject = new Chapter9Exercise1();
            string name = "Chris";
            // testObject.GreetinsByName(name);

            // check output agaist the expected value
            string expected = "Hello, Chris!";
            Assert.AreEqual(expected, sw.ToString());
        }
    }
}
