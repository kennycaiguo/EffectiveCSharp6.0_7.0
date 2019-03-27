using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace SameTypeConverter
{
    using static Iterator;

    class Program
    {
        static void Main(string[] args)
        {
            var myInts = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int i in Select(myInts, value => value * value))
                WriteLine(i);
        }
    }
}
