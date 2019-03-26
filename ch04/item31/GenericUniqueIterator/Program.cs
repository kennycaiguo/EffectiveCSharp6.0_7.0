using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace GenericUniqueIterator
{
    class Program
    {
        public static IEnumerable<T> Unique3<T>(IEnumerable<T> sequence)
        {
            var uniqueVals = new HashSet<T>();
            foreach (T item in sequence)
            {
                if (!uniqueVals.Contains(item))
                {
                    uniqueVals.Add(item);
                    yield return item;
                }
            }
        }

        static void Main(string[] args)
        {
            var nums = new int[] { 0, 3, 4, 5, 7, 3, 2, 7, 8, 0, 3, 1 };
            foreach (var num in Unique3(nums))
                WriteLine(num);

            var strings = new string[] { "Sasaki", "Sophia", "Sasaki", "Lisa", "Sophia" };
            foreach (var s in Unique3(strings))
                WriteLine(s);
        }
    }
}
