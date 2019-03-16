using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStaticUtility
{
    class Program
    {
        static void TestDouble()
        {
            double d1 = 4;
            double d2 = 5;
            double max = Utils<double>.Max(d1, d2);
            double min = Utils<double>.Min(d1, d2);

            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
        }

        static void TestString()
        {
            string foo = "foo";
            string bar = "bar";
            string sMax = Utils<string>.Max(foo, bar);
            string sMin = Utils<string>.Min(foo, bar);

            Console.WriteLine($"Max: {sMax}");
            Console.WriteLine($"Min: {sMin}");
        }

        static void Main(string[] args)
        {
            TestDouble();
            TestString();
        }
    }
}
