using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericZipper
{
    class Program
    {
        static void TestStringZip()
        {
            Console.WriteLine("TestStringZip():");

            var first = new string[] { "1", "2", "3", "4", "5", "6" };
            var second = new string[] { "i", "ii", "iii", "iv", "v", "vi" };
            var zip = Util.Zip(first, second);
            foreach (var elem in zip)
                Console.WriteLine(elem);
        }

        static void TestGenericZip()
        {
            Console.WriteLine("TestGenericZip():");

            var first = new int[] { 1, 2, 3, 4, 5, 6 };
            var second = new string[] { "i", "ii", "iii", "iv", "v", "vi" };
            var zip = Util.Zip(first, second, 
                (one, two) => string.Format($"{one} {two}"));
            foreach (var elem in zip)
                Console.WriteLine(elem);
        }

        static void Main(string[] args)
        {
            TestStringZip();
            TestGenericZip();
        }
    }
}
