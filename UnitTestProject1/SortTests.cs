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
        public void SortList_AscendingNumerical()
        {

        }
    }
}
