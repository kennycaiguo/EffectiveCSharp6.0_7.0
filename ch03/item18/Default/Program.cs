using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default
{
    class Program
    {
        static void TestInts()
        {
            Console.WriteLine("TestInts():");
            var ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int result;

            result = Utils.FirstOrDefault(ints, (i) => i % 7 == 0);
            Console.WriteLine($"FirstOrDefault(ints, (i) => i % 7 == 0) : {result}");

            result = Utils.FirstOrDefault(ints, (i) => i % 11 == 0);
            Console.WriteLine($"FirstOrDefault(ints, (i) => i % 11 == 0) : {result}");
        }

        static void TestStrings()
        {
            Console.WriteLine("TestStrings():");
            var strings = new List<string> { "abc", "def", "ghi", "jkl" };
            string result;

            result = Utils.FirstOrDefault(strings, (s) => s == "ghi");
            Console.WriteLine($"FirstOrDefault((strings, (s) => s == \"ghi\")) : {result}");

            result = Utils.FirstOrDefault(strings, (s) => s == "xyz");
            Console.WriteLine($"FirstOrDefault((strings, (s) => s == \"xyz\")) : {result}");

        }

        static void Main(string[] args)
        {
            TestInts();
            TestStrings();
        }
    }
}
