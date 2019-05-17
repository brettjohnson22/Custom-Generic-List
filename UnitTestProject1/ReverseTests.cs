﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class ReverseTests
    {
        [TestMethod]
        public void Reverse_ZeroIndex()
        {
            //arrange
            CustomList<char> testList = new CustomList<char>();
            char expectedResult = 'C';
            char actualResult;

            //act
            testList.Add('A');
            testList.Add('B');
            testList.Add('C');
            testList.Reverse();
            actualResult = testList[0];

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Reverse_LastIndex()
        {
            //arrange
            CustomList<char> testList = new CustomList<char>();
            char expectedResult = 'A';
            char actualResult;

            //act
            testList.Add('A');
            testList.Add('B');
            testList.Add('C');
            testList.Reverse();
            actualResult = testList[2];

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
