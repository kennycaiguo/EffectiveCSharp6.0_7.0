using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericStaticUtility
{
    class Program
    {
        static void TestDouble()
        {
            double d1 = 4;
            double d2 = 5;
            double max = Utils.Max(d1, d2);
            double min = Utils.Min(d1, d2);

            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
        }

        static void TestString()
        {
            string foo = "foo";
            string bar = "bar";
            string sMax = Utils.Max(foo, bar);
            string sMin = Utils.Min(foo, bar);

            Console.WriteLine($"Max: {sMax}");
            Console.WriteLine($"Min: {sMin}");
        }

        static void TestNullableDouble()
        {
            double? d1 = 12;
            double? d2 = null;
            // 2019.03.16 change
            //double? max = Utils.Max(d1, d2).Value;
            double? max = Utils.Max(d1, d2);
            double? min = Utils.Min(d1, d2);

            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
        }

        static void Main(string[] args)
        {
            TestDouble();
            TestString();
            TestNullableDouble();
        }
    }
}
