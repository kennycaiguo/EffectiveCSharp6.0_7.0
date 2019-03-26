using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace SquareUniqueIterator
{
    class Program
    {
        public static IEnumerable<T> Unique<T>(IEnumerable<T> sequence)
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

        public static IEnumerable<int> Square(IEnumerable<int> nums)
        {
            foreach (var num in nums)
                yield return num * num;
        }
        static void Main(string[] args)
        {
            var nums = new int[] { 0, 3, 4, 5, 7, 3, 2, 7, 8, 0, 3, 1 };
            foreach (var num in Square(Unique(nums)))
                WriteLine(num);
        }
    }
}
