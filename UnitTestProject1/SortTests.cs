using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void SortList_Alphabetical()
        {
            //arrange
            CustomList<char> testList = new CustomList<char>();
            testList.Add('B');
            testList.Add('C');
            testList.Add('G');
            testList.Add('A');
            char expectedResult = 'A';
            char actualResult;

            //act
            testList.Sort();
            actualResult = testList[0];

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SortList_NumericalFirstInt()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(4);
            test.Add(1);
            test.Add(6);
            test.Add(8);
            int expectedResult = 1;
            int actualResult;

            //act
            test.Sort();
            actualResult = test[0];

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SortList_NumericalLastInt()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(4);
            test.Add(1);
            test.Add(6);
            test.Add(8);
            int expectedResult = 8;
            int actualResult;

            //act
            test.Sort();
            actualResult = test[4];

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
