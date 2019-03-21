using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsForIEnumerableInt
{
    public static class Extensions
    {
        public static IEnumerable<T> Generate<T>(int count, Func<int, T> fn)
        {
            for (int i = 0; i < count; i++)
            {
                yield return fn(i);
            }
        }
    }
}
