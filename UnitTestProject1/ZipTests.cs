using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class ZipTests
    {
        [TestMethod]
        public void Zip_CheckCount()
        {
            //arrange
            CustomList<int> oddList = new CustomList<int>();
            CustomList<int> evenList = new CustomList<int>();
            CustomList<int> newList;
            int expectedResult = 6;
            int actualResult;

            //act
            oddList.Add(1);
            oddList.Add(3);
            oddList.Add(5);
            evenList.Add(2);
            evenList.Add(4);
            evenList.Add(6);
            newList = oddList.Zip(evenList);
            actualResult = newList.Count;

            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void Zip_CheckOneIndex()
        {
            //arrange
            CustomList<int> oddList = new CustomList<int>();
            CustomList<int> evenList = new CustomList<int>();
            CustomList<int> newList;
            int expectedResult = 2;
            int actualResult;
            //act
            oddList.Add(1);
            oddList.Add(3);
            oddList.Add(5);
            evenList.Add(2);
            evenList.Add(4);
            evenList.Add(6);
            newList = oddList.Zip(evenList);
            actualResult = newList[1];
            //assert
            Assert.AreEqual(actualResult, expectedResult);

        }
        [TestMethod]
        public void Zip_CheckLastIndex()
        {
            //arrange
            CustomList<int> oddList = new CustomList<int>();
            CustomList<int> evenList = new CustomList<int>();
            CustomList<int> newList;
            int expectedResult = 6;
            int actualResult;
            //act
            oddList.Add(1);
            oddList.Add(3);
            oddList.Add(5);
            evenList.Add(2);
            evenList.Add(4);
            evenList.Add(6);
            newList = oddList.Zip(evenList);
            actualResult = newList[5];
            //assert
            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        public void Zip_CheckLastIndexEvenLonger()
        {
            //arrange
            CustomList<int> oddList = new CustomList<int>();
            CustomList<int> evenList = new CustomList<int>();
            CustomList<int> newList;
            int expectedResult = 10;
            int actualResult;
            //act
            oddList.Add(1);
            oddList.Add(3);
            oddList.Add(5);
            evenList.Add(2);
            evenList.Add(4);
            evenList.Add(6);
            evenList.Add(8);
            evenList.Add(10);
            newList = oddList.Zip(evenList);
            actualResult = newList[7];
            //assert
            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        public void Zip_CheckLastIndexOddLonger()
        {
            //arrange
            CustomList<int> oddList = new CustomList<int>();
            CustomList<int> evenList = new CustomList<int>();
            CustomList<int> newList;
            int expectedResult = 9;
            int actualResult;
            //act
            oddList.Add(1);
            oddList.Add(3);
            oddList.Add(5);
            oddList.Add(7);
            oddList.Add(9);
            evenList.Add(2);
            evenList.Add(4);
            evenList.Add(6);
            newList = oddList.Zip(evenList);
            actualResult = newList[7];
            //assert
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}

