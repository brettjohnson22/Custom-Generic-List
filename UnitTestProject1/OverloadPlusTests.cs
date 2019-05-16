using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class OverloadPlusTests
    {
        [TestMethod]
        public void PlusOverride_Int()
        {
            //arrange
            CustomList<int> num1 = new CustomList<int>();
            CustomList<int> num2 = new CustomList<int>();
            CustomList<int> num3;
            int expectedResult = 4;
            int actualResult;

            //act
            num1.Add(1);
            num1.Add(2);
            num2.Add(3);
            num2.Add(4);

            num3 = num1 + num2;
            actualResult = num3[3];

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void PlusOverride_DifferentSizes()
        {
            //arrange
            CustomList<int> num1 = new CustomList<int>();
            CustomList<int> num2 = new CustomList<int>();
            CustomList<int> num3;
            int expectedResult = 6;
            int actualResult;
            //act
            num1.Add(1);
            num1.Add(2);
            num2.Add(3);
            num2.Add(4);
            num2.Add(5);
            num2.Add(6);
            num3 = num1 + num2;
            actualResult = num3[5];
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void PlusOverride_CheckCount()
        {
            //arrange
            CustomList<int> num1 = new CustomList<int>();
            CustomList<int> num2 = new CustomList<int>();
            CustomList<int> num3;
            int expectedResult = 4;
            int actualResult;

            //act
            num1.Add(1);
            num1.Add(2);
            num2.Add(3);
            num2.Add(4);

            num3 = num1 + num2;
            actualResult = num3.Count;

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
