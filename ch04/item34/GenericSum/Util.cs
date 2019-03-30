using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSum
{
    public static class Util
    {
        public static int Sum(IEnumerable<int> nums)
        {
            var total = 0;
            foreach (int num in nums)
            {
                total += num;
            }
            return total;
        }

        public static T Sum<T>(IEnumerable<T> sequence, T total,
            Func<T, T, T> accumulator)
        {
            foreach (T item in sequence)
            {
                total = accumulator(total, item);
            }
            return total;
        }
    }
}
