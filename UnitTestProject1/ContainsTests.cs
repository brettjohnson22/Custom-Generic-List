using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class ContainsTests
    {
        [TestMethod]
        public void Contains_DoesContain_True()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(4);
            test.Add(1);
            test.Add(6);
            test.Add(8);
            bool actualResult;

            //act
            actualResult = test.Contains(4);

            //assert
            Assert.IsTrue(actualResult);
        }
        [TestMethod]
        public void Contains_DoesNotContain_False()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(4);
            test.Add(1);
            test.Add(6);
            test.Add(8);
            bool actualResult;

            //act
            actualResult = test.Contains(7);

            //assert
            Assert.IsFalse(actualResult);
        }
    }
}
