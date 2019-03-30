using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFold
{
    public static class Util
    {
        public static TResult Fold<T, TResult>(
            IEnumerable<T> sequence,
            TResult total,
            Func<T, TResult, TResult> accumulator)
        {
            foreach (T item in sequence)
            {
                total = accumulator(item, total);
            }
            return total;
        }
    }
}
