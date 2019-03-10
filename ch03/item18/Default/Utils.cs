using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default
{
    public static class Utils
    {
        public static T FirstOrDefault<T>(this IEnumerable<T> sequence,
            Predicate<T> test)
        {
            foreach (T value in sequence)
                if (test(value))
                    return value;
            return default(T);
        }
    }
}
