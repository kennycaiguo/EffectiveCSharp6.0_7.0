using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace DifferentTypeConverter
{
    using static Iterator;

    class Program
    {
        static void Main(string[] args)
        {
            var myInts = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            WriteLine("convert int to string:");
            foreach (string s in Select(myInts, value => value.ToString()))
                WriteLine(s);

            WriteLine("convert int to double:");
            foreach (double d in Select(myInts, value => Math.Sqrt(value)))
                WriteLine(d);

        }
    }
}
