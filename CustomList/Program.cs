using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomList<string> testList = new CustomList<string>();
            //testList.Add("hi");
            //testList.Add("hi");
            //testList.Add("hi");
            //testList.Add("hi");
            //testList.Add("hi");
            //testList.Add("hi");
            //testList.Add("hi");
            //testList.Add("hi");
            //testList.Add("hi");
            //testList.Add("hi");
            //testList.Add("hi");
            //testList.Add("hi");
            //testList.Add("hi");
            //testList.Add("hi");
            //testList.Add("hi");
            //testList.Remove("hi");

            //CustomList<int> nums = new CustomList<int>();
            //nums.Add(5);
            //nums.Add(6);
            //nums.Add(7);
            //nums.Remove(5);
            //nums.ToString();

            //CustomList<string> testList = new CustomList<string>();
            //Console.WriteLine(testList.Capacity);
            //testList.Add("one");
            //Console.WriteLine(testList.Capacity);
            //testList.Add("two");
            //Console.WriteLine(testList.Capacity);
            //testList.Add("one");
            //testList.Add("three");
            //Console.WriteLine(testList.Count);
            //Console.WriteLine(testList.Capacity);
            //testList.Remove("one");

            //Console.WriteLine(testList[0]);
            //Console.WriteLine(testList[1]);
            //Console.WriteLine(testList.Count);
            //Console.WriteLine(testList.Capacity);
            //Console.WriteLine(testList.ToString());
            //Console.ReadLine();

            //List<int> test = new List<int>();
            //test.Add(1);
            //test.Add(2);
            //test.Add(3);
            //test.Add(4);

            //string tester = test.ToString();

            //Console.WriteLine(test.ToString());
            //Console.ReadLine()
            //    CustomList<int> testList = new CustomList<int>();
            //    testList.Add(1);
            //    testList.Add(2);
            //    testList.Add(3);
            //    testList.Add(4);
            //    testList.Add(5);
            //    foreach (int el in testList)
            //    {
            //        Console.WriteLine(el);
            //    }
            //Console.ReadLine();
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(4);
            test.Add(1);
            test.Add(6);
            test.Add(8);
            test.Sort();
            Console.WriteLine(test);
            Console.ReadLine();

        }

    }
}
