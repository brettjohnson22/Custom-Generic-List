using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class RemoveUnitTests
    {
        [TestMethod]
        public void Remove_ZeroIndexFromOneLengthList()
        {   
            //arrange
            CustomList<string> testList = new CustomList<string>();
            testList.Add("one");

            //act
            testList.Remove("one");
            Console.WriteLine(testList[0]);
  
            //assert
            Assert.AreEqual(null, testList[0]);
        }
        [TestMethod]
        public void Remove_ZeroIndexIntFromOneLengthList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(3);
            int expectedValue = 0;
            int actualValue;
            //act
            testList.Remove(3);
            actualValue = testList[0];
            Console.WriteLine(actualValue);
            //assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Remove_FinalCapacityInt()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            int expectedValue = 0;
            int actualValue;
            //act
            testList.Remove(4);
            actualValue = testList[3];
            Console.WriteLine(actualValue);
            //assert
            Assert.AreEqual(expectedValue, actualValue);
            
        }
        [TestMethod]
        public void Remove_FinalCapacityString()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            testList.Add("one");
            testList.Add("two");
            testList.Add("three");
            testList.Add("four");
            string expectedValue = null;
            string actualValue;
            //act
            testList.Remove("four");
            actualValue = testList[3];
            Console.WriteLine(actualValue);
            //assert
            Assert.AreEqual(expectedValue, actualValue);

        }
        [TestMethod]
        public void Remove_ZeroIndexFromTwoLengthList_MoveIndexOneToZero()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            testList.Add("one");
            testList.Add("two");
            string expectedValue = "two";
            string actualValue;
            //act
            testList.Remove("one");
            actualValue = testList[0];
            //assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Remove_ChangeCountAfterRemovingOnlyItem()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            testList.Add("one");
            int expectedValue = 0;
            int actualValue;
            //act
            testList.Remove("one");
            actualValue = testList.Count;
            //assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Remove_ChangeCountAfterRemovingItem()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            testList.Add("one");
            testList.Add("two");
            testList.Add("three");
            int expectedValue = 2;
            int actualValue;
            //act
            testList.Remove("one");
            actualValue = testList.Count;
            //assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Remove_RemoveANonIncludedItemWontRemoveAnything()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            testList.Add("one");
            string expectedValue = "one";
            string actualValue;
            //act
            testList.Remove("two");
            actualValue = testList[0];
            //assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Remove_RemoveOnlyFirstInstance()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            testList.Add("one");
            testList.Add("two");
            testList.Add("one");
            string expectedValue = "one";
            //act
            testList.Remove("one");
            string actualValue = testList[1];
            //assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Remove_RemoveFinalItemFromList()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            testList.Add("one");
            testList.Add("two");
            testList.Add("three");
            string expectedValue = "two";
            string actualValue;
            //act
            testList.Remove("three");
            actualValue = testList[testList.Count - 1];
            //assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
