using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace UniueIterator
{
    class Program
    {
        public static IEnumerable<int> Unique2(IEnumerable<int> nums)
        {
            var uniqueVals = new HashSet<int>();
            foreach (var num in nums)
            {
                if (!uniqueVals.Contains(num))
                {
                    uniqueVals.Add(num);
                    yield return num;
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
