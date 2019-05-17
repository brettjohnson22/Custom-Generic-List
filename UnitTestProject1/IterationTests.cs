using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class IterationTests
    {
        [TestMethod]
        public void ForEach_First()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            int expectedResult = 1;
            int actualResult;

            //act
            foreach (int el in testList)
            {
                newList.Add(el);
            }
            actualResult = newList[0];

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ForEach_Last()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            int expectedResult = 3;
            int actualResult;

            //act
            foreach(int el in testList)
            {
                newList.Add(el);
            }
            actualResult = newList[2];

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
