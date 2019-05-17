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
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(4);
            test.Add(1);
            test.Add(6);
            test.Add(8);

            Console.WriteLine(test.Count);
            Console.ReadLine();

            List<int> tesert = new List<int>();
        }
    }
}
