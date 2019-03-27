using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace EveryNthItemFilter
{
    using static Iterator;

    class Program
    {
        static void Main(string[] args)
        {
            var ints = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var filtered = EveryNthItem(ints, 3);
            foreach (var item in filtered)
                WriteLine(item);
        }
    }
}
