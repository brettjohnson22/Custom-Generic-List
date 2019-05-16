using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class ToStringTests
    {
        [TestMethod]
        public void ToString_StringsToString()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            string expectedResult = "Hello World!";
            string actualResult;

            //act
            testList.Add("Hello ");
            testList.Add("World");
            testList.Add("!");
            actualResult = testList.ToString();

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ToString_CharsToString()
        {
            //arrange
            CustomList<char> testList = new CustomList<char>();
            string expectedResult = "ABC";
            string actualResult;

            //act
            testList.Add('A');
            testList.Add('B');
            testList.Add('C');
            actualResult = testList.ToString();

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ToString_IntToString()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            string expectedResult = "123";
            string actualResult;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            actualResult = testList.ToString();

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        //    [TestMethod]
        //    [ExpectedException(typeof())]
        //    public void ToString_CannotConvertToStringThrowsException()
        //    {

        //    }
    }
}
