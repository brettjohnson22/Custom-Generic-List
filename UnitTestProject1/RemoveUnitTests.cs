using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class RemoveUnitTests
    {
        [TestMethod]
        public void Remove_ZeroIndexFromOneLengthList_MakeZeroIndexNull()
        {   
            //arrange
            CustomList<string> testList = new CustomList<string>();
            testList[0] = "one";

            //act
            testList.Remove("one");

            //assert
            Assert.AreEqual(null, testList[0]);
        }

        public void Remove_ZeroIndexFromTwoLengthList_MoveIndezOneToZero()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            testList[0] = "one";
            testList[1] = "two";
            string expectedValue = "two";

            //act
            testList.Remove("one");

            //assert
            Assert.AreEqual(expectedValue, testList[0]);
        }

        public void Remove_
    }
}
