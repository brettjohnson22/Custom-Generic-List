using System;
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
        [TestMethod]
        public void Reverse_Overload()
        {
            //arrange
            CustomList<char> testList = new CustomList<char>();
            string expectedResult = "AEDCBF";
            string actualResult;

            //act
            testList.Add('A');
            testList.Add('B');
            testList.Add('C');
            testList.Add('D');
            testList.Add('E');
            testList.Add('F');
            testList.Reverse(1, 4);
            actualResult = testList.ToString();

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Reverse_Overload_ArgumentOOB()
        {
            //arrange
            CustomList<char> testList = new CustomList<char>();
            string expectedResult = "ADCBE";
            string actualResult;

            //act
            testList.Add('A');
            testList.Add('B');
            testList.Add('C');
            testList.Add('D');
            testList.Add('E');
            testList.Reverse(-1, 3);
            actualResult = testList.ToString();

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Reverse_Overload_IndexOOB()
        {
            //arrange
            CustomList<char> testList = new CustomList<char>();
            string expectedResult = "ADCBE";
            string actualResult;

            //act
            testList.Add('A');
            testList.Add('B');
            testList.Add('C');
            testList.Add('D');
            testList.Add('E');
            testList.Reverse(9, 3);
            actualResult = testList.ToString();

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
