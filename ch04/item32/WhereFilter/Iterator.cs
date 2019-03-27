using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereFilter
{
    public static class Iterator
    {
        public static IEnumerable<T> Where<T>
            (IEnumerable<T> sequence, Predicate<T> filterFunc)
        {
            if (sequence == null)
                throw new ArgumentNullException(nameof(sequence),
                    "シーケンスをnullにできません");
            if (filterFunc == null)
                throw new ArgumentNullException(nameof(filterFunc),
                    "述語をnullにできません");
            foreach (T item in sequence)
                if (filterFunc(item))
                    yield return item;
        }
    }
}
