using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class AddUnitTests
    {
        [TestMethod]
        public void Add_PositiveInt0Index()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value = 3;

            //act
            testList.Add(value);

            //assert
            Assert.AreEqual(value, testList[0]);
        }
        [TestMethod]
        public void Add_PositiveInt1Index()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value = 3;
            int value1 = 5;
            //act
            testList.Add(value);
            testList.Add(value1);
            //assert
            Assert.AreEqual(value1, testList[1]);

        }
        [TestMethod]
        public void Add_PositiveInt4Index()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value = 2;
            int value1 = 5;
            //act
            testList.Add(value);
            testList.Add(value);
            testList.Add(value);
            testList.Add(value);
            testList.Add(value1);
            //assert
            Assert.AreEqual(value1, testList[4]);

        }
        [TestMethod]
        public void Add_PositiveInt_CheckCount()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value = 2;
            int countBeforeAdd;
            int countAfterAdd;

            //act
            countBeforeAdd = testList.Count;
            testList.Add(value);
            countAfterAdd = testList.Count;

            //assert
            Assert.AreEqual(countBeforeAdd + 1, countAfterAdd);
        }
        [TestMethod]
        public void Add_String0Index()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            string value = "testString";
            //act
            testList.Add(value);

            //assert
            Assert.AreEqual(value, testList[0]);
        }
        [TestMethod]
        public void Add_String1Index()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            string value = "testString";
            string value1 = "nextString";
            //act
            testList.Add(value);
            testList.Add(value1);

            //assert
            Assert.AreEqual(value1, testList[1]);
        }
        [TestMethod]
        public void Add_String_CheckCount()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            string value = "testString";
            int countBeforeAdd;
            int countAfterAdd;
            //act
            countBeforeAdd = testList.Count;
            testList.Add(value);
            countAfterAdd = testList.Count;


            //assert
            Assert.AreEqual(countBeforeAdd + 1, countAfterAdd);
        }
        [TestMethod]
        public void Add_Strings_Increase_Capacity()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            string value = "what";
            int testCapacity;

            //act
            testList.Add(value);
            testList.Add(value);
            testList.Add(value);
            testList.Add(value);
            testList.Add(value);
            testCapacity = testList.Capacity;
            //assert
            Assert.AreEqual(8, testCapacity);

        }

    }
}
