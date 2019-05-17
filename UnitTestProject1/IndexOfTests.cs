using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class IndexOfTests
    {
        [TestMethod]
        public void IndexOf_Index1()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(4);
            test.Add(1);
            int expectedResult = 1;
            int actualResult;

            //act
            actualResult = test.IndexOf(4);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void IndexOf_Index1_OnlyFirstInstance()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(4);
            test.Add(1);
            test.Add(4);
            int expectedResult = 1;
            int actualResult;

            //act
            actualResult = test.IndexOf(4);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
