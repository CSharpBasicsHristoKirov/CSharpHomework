using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chapter9Exercise4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9Exercise4.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        /*
            Method: FrequencyOfNTest();

            It checks whether the expeced
            value matches the result returned
            by the tested function.
        */
        [TestMethod()]
        public void FrequencyOfNTest()
        {
            // arrange
            int[] arr = { 1, 1, 1, 2, 3, 4, 5 };
            int target= 1;

            // occurences
            int actual = 3;
            int? measured = null;

            // act
            measured = Program.FrequencyOfN(target, arr);

            // assert
            Assert.AreEqual(measured, actual);
        }
    }
}