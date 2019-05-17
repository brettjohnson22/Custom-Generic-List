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
        public void IndexOf_NotFound()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(4);
            test.Add(1);
            int expectedResult = -1;
            int actualResult;

            //act
            actualResult = test.IndexOf(8);

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
        [TestMethod]
        public void IndexOf_ParameterOverload_BeforeSearchIndex()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(7);
            test.Add(4);
            test.Add(1);
            test.Add(2);
            test.Add(4);
            test.Add(1);
            int expectedResult = -1;
            int actualResult;

            //act
            actualResult = test.IndexOf(7, 2);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void IndexOf_ParameterOverload_Found()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(4);
            test.Add(1);
            test.Add(2);
            test.Add(4);
            test.Add(1);
            int expectedResult = 4;
            int actualResult;

            //act
            actualResult = test.IndexOf(4, 2);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexOf_ParameterOverload_OutOfRange()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(5);
            test.Add(1);

            int expectedResult = -1;
            int actualResult;

            //act
            actualResult = test.IndexOf(5, 9);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void IndexOf_SecondParameterOverload_OutsideOfCountNotFound()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(4);
            test.Add(1);
            test.Add(2);
            test.Add(1);
            test.Add(1);
            test.Add(4);
            test.Add(2);

            int expectedResult = - 1;
            int actualResult;

            //act
            actualResult = test.IndexOf(4, 2, 3);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void IndexOf_SecondParameterOverload_Found()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(5);
            test.Add(1);
            test.Add(2);
            test.Add(5);
            test.Add(2);

            int expectedResult = 4;
            int actualResult;

            //act
            actualResult = test.IndexOf(5, 2, 4);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void IndexOf_SecondParameterOverload_CountTooBig()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(5);
            test.Add(1);
            test.Add(2);
            test.Add(5);
            test.Add(2);

            int expectedResult = 4;
            int actualResult;

            //act
            actualResult = test.IndexOf(5, 2, 10);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void IndexOf_SecondParameterOverload_CountTooBigCantFind()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(5);
            test.Add(1);
            test.Add(2);
            test.Add(5);
            test.Add(2);

            int expectedResult = -1;
            int actualResult;

            //act
            actualResult = test.IndexOf(7, 2, 10);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
