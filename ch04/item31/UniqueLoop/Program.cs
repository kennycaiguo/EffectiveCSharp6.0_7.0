using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2019.03.26 add
using static System.Console;

namespace UniqueLoop
{
    class Program
    {
        public static void Unique(IEnumerable<int> nums)
        {
            var uniqueVals = new HashSet<int>();
            foreach (var num in nums)
            {
                if (!uniqueVals.Contains(num))
                {
                    uniqueVals.Add(num);
                    WriteLine(num);
                }
            }
        }

        static void Main(string[] args)
        {
            var nums = new int[] { 0, 3, 4, 5, 7, 3, 2, 7, 8, 0, 3, 1 };
            Unique(nums);
        }
    }
}
