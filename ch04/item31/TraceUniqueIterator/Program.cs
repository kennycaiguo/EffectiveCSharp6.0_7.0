using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace TraceUniqueIterator
{
    class Program
    {
        public static IEnumerable<int> Unique2(IEnumerable<int> nums)
        {
            var uniqueVals = new HashSet<int>();
            WriteLine("\tUniqueを実行中");
            foreach (var num in nums)
            {
                WriteLine($"\t{num} を評価中");
                if (!uniqueVals.Contains(num))
                {
                    WriteLine($"\t{num} を追加中");
                    uniqueVals.Add(num);
                    yield return num;
                    WriteLine($"\tyield return 後に再実行中");
                }
            }
        }

        static void Main(string[] args)
        {
            var nums = new int[] { 0, 3, 4, 5, 7, 3, 2, 7, 8, 0, 3, 1 };
            foreach (var num in Unique2(nums))
                WriteLine(num);
        }
    }
}
