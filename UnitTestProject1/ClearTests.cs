using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class ClearTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Clear_ResultsInOutOfRangeExceptionAtZeroIndex()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(4);
            test.Add(1);
            test.Add(6);
            test.Add(8);
            int expectedValue = 0;
            int actualValue;

            //act
            test.Clear();
            actualValue = test[0];

            //assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Clear_CountOfZero()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(4);
            test.Add(1);
            test.Add(6);
            test.Add(8);
            int expectedValue = 0;
            int actualValue;

            //act
            test.Clear();
            actualValue = test.Count;

            //assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
