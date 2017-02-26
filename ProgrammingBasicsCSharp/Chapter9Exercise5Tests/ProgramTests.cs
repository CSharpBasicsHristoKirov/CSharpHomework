using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chapter9Exercise5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Build and run tests: https://msdn.microsoft.com/en-us/library/ms182532.aspx
*/

namespace Chapter9Exercise5.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        /*
            Method: InputvalidityGreaterThanAdjacentTest();

            It tests input parameters validity.
        */
        [TestMethod()]
        public void InputValidityGreaterThanNeighbouringTest()
        {
            // arrange
            // case 1 index out of lower bound
            int[] arr = { 1, 1, 2, 1, 1 };
            int targetIndex = -1;

            // case 2 index out of upper bound
            int[] arr2 = { 1, 1, 2, 1, 1 };
            int targetIndex2 = 6;

            // case 3 empty array
            int[] arr3 = new int[0];
            int targetIndex3 = 0;

            // act
            bool res1 = Program.GreaterThanNeigbouring(targetIndex, arr);
            bool res2 = Program.GreaterThanNeigbouring(targetIndex2, arr2);
            bool res3 = Program.GreaterThanNeigbouring(targetIndex3, arr3);

            // assert
            // handled by Expected Exception
        }

        /*
            Method: GreaterThanAdjacentTest();

            It tests returned result validity.
        */
        [TestMethod()]
        public void ResultValidityGreaterThanNeighbouringTest()
        {
            // arrange
            int[] arr = { 1, 1, 2, 1, 1 };
            int targetIndex = 2;
            bool actual = true;

            // act
            bool measured = Program.GreaterThanNeigbouring(targetIndex, arr);

            // assert
            Assert.AreEqual(actual, measured);
        }
    }
}