using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSum
{
    using static Util;

    class Program
    {
        static void TestIntSum()
        {
            Console.WriteLine("TestIntSum():");
            var sequence = Enumerable.Range(1, 100);
            var total = 0;
            total = Sum(sequence);
            Console.WriteLine($"total: {total}");
        }

        static void TestGenericSum()
        {
            Console.WriteLine("TestGenericSum():");
            var sequence = Enumerable.Range(1, 100);
            var total = 0;
            total = Sum(sequence, total, (sum, num) => sum + num);
            Console.WriteLine($"total: {total}");
        }

        static void Main(string[] args)
        {
            TestIntSum();
            TestGenericSum();
        }
    }
}
