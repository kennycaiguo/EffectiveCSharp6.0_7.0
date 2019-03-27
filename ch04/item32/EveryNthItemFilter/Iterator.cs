using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryNthItemFilter
{
    public static class Iterator
    {
        public static IEnumerable<T> EveryNthItem<T>(
            IEnumerable<T> sequence, int period)
        {
            var count = 0;
            foreach (T item in sequence)
                if (++count % period == 0)
                    yield return item;
        }
    }
}
