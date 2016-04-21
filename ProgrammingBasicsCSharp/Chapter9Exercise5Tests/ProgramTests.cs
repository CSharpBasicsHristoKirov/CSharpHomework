using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chapter9Exercise5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void InputValidityGreaterThanAdjacentTest()
        {
            // arrange
            // case 1 index out of lower bound
            int[] Array = { 1, 1, 2, 1, 1 };
            int TargetIndex = -1;

            // case 2 index out of upper bound
            int[] Array2 = { 1, 1, 2, 1, 1 };
            int TargetIndex2 = 6;

            // case 3 empty array
            int[] Array3 = new int[0];
            int TargetIndex3 = 0;

            // act
            Program.GreaterThanAdjacent(TargetIndex, Array);

            // assert
            // handled by ExpectedException
        }

        /*
            Method: GreaterThanAdjacentTest();

            It tests returned result validity.
        */
        [TestMethod()]
        public void ResultValidityGreaterThanAdjacentTest()
        {
            // arrange
            int[] Array = { 1, 1, 2, 1, 1 };
            int TargetIndex = 2;
            bool ExpectedResult = true;

            // act
            bool ActualResult = Program.GreaterThanAdjacent(TargetIndex, Array);

            // assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}