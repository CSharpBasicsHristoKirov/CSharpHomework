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
            int[] Array = { 1, 1, 1, 2, 3, 4, 5 };
            int TargetElement = 1;
            int actual = 0;
            int expected = 3;

            // act
            actual = Program.FrequencyOfN(TargetElement, Array);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}