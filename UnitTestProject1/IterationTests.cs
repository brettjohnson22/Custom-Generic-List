using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class IterationTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            foreach(int el in testList)
            {
                Console.WriteLine(el);
            }
        }
    }
}
