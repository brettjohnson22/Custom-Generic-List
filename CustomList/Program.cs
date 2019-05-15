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

            CustomList<int> nums = new CustomList<int>();
            nums.Add(5);
            nums.Add(6);
            nums.Add(7);
            nums.Remove(5);


        }

    }
}
